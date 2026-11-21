using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005911 RID: 22801
	public class SolarSchoolForumPostItem : GridProxyAbstract<int>
	{
		// Token: 0x06038369 RID: 230249 RVA: 0x00FB745C File Offset: 0x00FB565C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603836A RID: 230250 RVA: 0x00FB754C File Offset: 0x00FB574C
		public override void Refresh(int postId, bool isSelected, int gridIndex)
		{
			SolarSchoolForumPost? forumPost = SolarSchoolConfig.Instance.GetForumPost(postId);
			if (forumPost == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Forum] 论坛楼层配置缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("postId", postId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), forumPost.Value.UserName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), forumPost.Value.Content, Array.Empty<object>());
			string contentImage = forumPost.Value.ContentImage;
			if (string.IsNullOrEmpty(contentImage))
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				base.TrySetTextureByPath(contentImage, base.GetTexture(3), null, null);
				UUIItem item2 = base.GetItem(2);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0603836B RID: 230251 RVA: 0x00FB763E File Offset: 0x00FB583E
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0200B4D5 RID: 46293
		private class EComponents
		{
			// Token: 0x04037E97 RID: 229015
			public const int PnlItem = 0;

			// Token: 0x04037E98 RID: 229016
			public const int TxtName = 1;

			// Token: 0x04037E99 RID: 229017
			public const int PnlPic = 2;

			// Token: 0x04037E9A RID: 229018
			public const int TexPic = 3;

			// Token: 0x04037E9B RID: 229019
			public const int PnlTxt = 4;

			// Token: 0x04037E9C RID: 229020
			public const int TxtDetails = 5;
		}
	}
}
