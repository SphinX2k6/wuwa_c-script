using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C0 RID: 4288
	public struct SkillGameplayButton : IFlatbufferObject
	{
		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600D500 RID: 54528 RVA: 0x00317356 File Offset: 0x00315556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x00317363 File Offset: 0x00315563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x0031736C File Offset: 0x0031556C
		public static SkillGameplayButton GetRootAsSkillGameplayButton(ByteBuffer _bb)
		{
			return SkillGameplayButton.GetRootAsSkillGameplayButton(_bb, default(SkillGameplayButton));
		}

		// Token: 0x0600D503 RID: 54531 RVA: 0x00317388 File Offset: 0x00315588
		public static SkillGameplayButton GetRootAsSkillGameplayButton(ByteBuffer _bb, SkillGameplayButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D504 RID: 54532 RVA: 0x003173A5 File Offset: 0x003155A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D505 RID: 54533 RVA: 0x003173B4 File Offset: 0x003155B4
		public SkillGameplayButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x003173C4 File Offset: 0x003155C4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600D507 RID: 54535 RVA: 0x00317400 File Offset: 0x00315600
		public int GameplayType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x0031743C File Offset: 0x0031563C
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D509 RID: 54537 RVA: 0x00317473 File Offset: 0x00315673
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D50A RID: 54538 RVA: 0x00317482 File Offset: 0x00315682
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600D50B RID: 54539 RVA: 0x0031749C File Offset: 0x0031569C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x003174D4 File Offset: 0x003156D4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x003174E4 File Offset: 0x003156E4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x003174FC File Offset: 0x003156FC
		public int ButtonType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600D50F RID: 54543 RVA: 0x0031753C File Offset: 0x0031573C
		public int ActionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600D510 RID: 54544 RVA: 0x0031757C File Offset: 0x0031577C
		public string SkillIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x003175B4 File Offset: 0x003157B4
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x003175C4 File Offset: 0x003157C4
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D513 RID: 54547 RVA: 0x003175DC File Offset: 0x003157DC
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600D514 RID: 54548 RVA: 0x0031761C File Offset: 0x0031581C
		public int SkillIconTagsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x00317648 File Offset: 0x00315848
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600D516 RID: 54550 RVA: 0x00317658 File Offset: 0x00315858
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600D517 RID: 54551 RVA: 0x00317670 File Offset: 0x00315870
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600D518 RID: 54552 RVA: 0x003176B0 File Offset: 0x003158B0
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600D519 RID: 54553 RVA: 0x003176F0 File Offset: 0x003158F0
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x00317730 File Offset: 0x00315930
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillGameplayButton skillGameplayButton = this;
			return skillGameplayButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x00317754 File Offset: 0x00315954
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillGameplayButton.<SkillIconTagsIter>d__40 <SkillIconTagsIter>d__ = new SkillGameplayButton.<SkillIconTagsIter>d__40(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x040051E9 RID: 20969
		private Table __p;
	}
}
