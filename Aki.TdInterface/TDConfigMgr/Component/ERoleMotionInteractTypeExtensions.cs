using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABF RID: 2751
	public static class ERoleMotionInteractTypeExtensions
	{
		// Token: 0x06003C6E RID: 15470 RVA: 0x0009B0C8 File Offset: 0x000992C8
		public static string ToEnumString(this ERoleMotionInteractType value)
		{
			string result;
			if (value == ERoleMotionInteractType.PetalGrab)
			{
				result = "PetalGrab";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x0009B0F0 File Offset: 0x000992F0
		public static ERoleMotionInteractType FromString(string name)
		{
			ERoleMotionInteractType result;
			if (!ERoleMotionInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleMotionInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x0009B119 File Offset: 0x00099319
		public static bool TryFromString(string name, out ERoleMotionInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoleMotionInteractType.PetalGrab;
				return false;
			}
			if (name == "PetalGrab")
			{
				value = ERoleMotionInteractType.PetalGrab;
				return true;
			}
			value = ERoleMotionInteractType.PetalGrab;
			return false;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x0009B13E File Offset: 0x0009933E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PetalGrab"
			};
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0009B14E File Offset: 0x0009934E
		public static ERoleMotionInteractType[] GetValues()
		{
			return new ERoleMotionInteractType[1];
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0009B156 File Offset: 0x00099356
		public static string[] GetNames()
		{
			return new string[]
			{
				"PetalGrab"
			};
		}
	}
}
