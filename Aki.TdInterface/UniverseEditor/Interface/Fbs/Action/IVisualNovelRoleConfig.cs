using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD9 RID: 32217
	public struct IVisualNovelRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700F15A RID: 61786
		// (get) Token: 0x0603A38B RID: 238475 RVA: 0x007D8C94 File Offset: 0x007D6E94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A38C RID: 238476 RVA: 0x007D8CA1 File Offset: 0x007D6EA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A38D RID: 238477 RVA: 0x007D8CA8 File Offset: 0x007D6EA8
		public static IVisualNovelRoleConfig GetRootAsIVisualNovelRoleConfig(ByteBuffer _bb)
		{
			return IVisualNovelRoleConfig.GetRootAsIVisualNovelRoleConfig(_bb, default(IVisualNovelRoleConfig));
		}

		// Token: 0x0603A38E RID: 238478 RVA: 0x007D8CC4 File Offset: 0x007D6EC4
		public static IVisualNovelRoleConfig GetRootAsIVisualNovelRoleConfig(ByteBuffer _bb, IVisualNovelRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A38F RID: 238479 RVA: 0x007D8CE1 File Offset: 0x007D6EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A390 RID: 238480 RVA: 0x007D8CF0 File Offset: 0x007D6EF0
		public IVisualNovelRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F15B RID: 61787
		// (get) Token: 0x0603A391 RID: 238481 RVA: 0x007D8D00 File Offset: 0x007D6F00
		public int Expression
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

		// Token: 0x1700F15C RID: 61788
		// (get) Token: 0x0603A392 RID: 238482 RVA: 0x007D8D3C File Offset: 0x007D6F3C
		public EAvgVisualEffect VisualEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAvgVisualEffect.Default;
				}
				return (EAvgVisualEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F15D RID: 61789
		// (get) Token: 0x0603A393 RID: 238483 RVA: 0x007D8D78 File Offset: 0x007D6F78
		public bool HideAvatar
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F15E RID: 61790
		// (get) Token: 0x0603A394 RID: 238484 RVA: 0x007D8DB8 File Offset: 0x007D6FB8
		public bool HidePortrait
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F15F RID: 61791
		// (get) Token: 0x0603A395 RID: 238485 RVA: 0x007D8DF8 File Offset: 0x007D6FF8
		public int CustomLayer
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

		// Token: 0x1700F160 RID: 61792
		// (get) Token: 0x0603A396 RID: 238486 RVA: 0x007D8E38 File Offset: 0x007D7038
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A397 RID: 238487 RVA: 0x007D8E75 File Offset: 0x007D7075
		public static Offset<IVisualNovelRoleConfig> CreateIVisualNovelRoleConfig(FlatBufferBuilder builder, int Expression = 0, EAvgVisualEffect VisualEffect = EAvgVisualEffect.Default, bool HideAvatar = false, bool HidePortrait = false, int CustomLayer = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelRoleConfig.AddCustomLayer(builder, CustomLayer);
			IVisualNovelRoleConfig.AddExpression(builder, Expression);
			IVisualNovelRoleConfig.AddNullMask(builder, NullMask);
			IVisualNovelRoleConfig.AddHidePortrait(builder, HidePortrait);
			IVisualNovelRoleConfig.AddHideAvatar(builder, HideAvatar);
			IVisualNovelRoleConfig.AddVisualEffect(builder, VisualEffect);
			return IVisualNovelRoleConfig.EndIVisualNovelRoleConfig(builder);
		}

		// Token: 0x0603A398 RID: 238488 RVA: 0x007D8EB1 File Offset: 0x007D70B1
		public static void StartIVisualNovelRoleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603A399 RID: 238489 RVA: 0x007D8EBA File Offset: 0x007D70BA
		public static void AddExpression(FlatBufferBuilder builder, int expression)
		{
			builder.AddInt(0, expression, 0);
		}

		// Token: 0x0603A39A RID: 238490 RVA: 0x007D8EC5 File Offset: 0x007D70C5
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(1, (byte)visualEffect, 0);
		}

		// Token: 0x0603A39B RID: 238491 RVA: 0x007D8ED0 File Offset: 0x007D70D0
		public static void AddHideAvatar(FlatBufferBuilder builder, bool hideAvatar)
		{
			builder.AddBool(2, hideAvatar, false);
		}

		// Token: 0x0603A39C RID: 238492 RVA: 0x007D8EDB File Offset: 0x007D70DB
		public static void AddHidePortrait(FlatBufferBuilder builder, bool hidePortrait)
		{
			builder.AddBool(3, hidePortrait, false);
		}

		// Token: 0x0603A39D RID: 238493 RVA: 0x007D8EE6 File Offset: 0x007D70E6
		public static void AddCustomLayer(FlatBufferBuilder builder, int customLayer)
		{
			builder.AddInt(4, customLayer, 0);
		}

		// Token: 0x0603A39E RID: 238494 RVA: 0x007D8EF1 File Offset: 0x007D70F1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603A39F RID: 238495 RVA: 0x007D8EFC File Offset: 0x007D70FC
		public static Offset<IVisualNovelRoleConfig> EndIVisualNovelRoleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleConfig>(builder.EndTable());
		}

		// Token: 0x0603A3A0 RID: 238496 RVA: 0x007D8F0C File Offset: 0x007D710C
		public IVisualNovelRoleConfigT UnPack()
		{
			IVisualNovelRoleConfigT visualNovelRoleConfigT = new IVisualNovelRoleConfigT();
			this.UnPackTo(visualNovelRoleConfigT);
			return visualNovelRoleConfigT;
		}

		// Token: 0x0603A3A1 RID: 238497 RVA: 0x007D8F28 File Offset: 0x007D7128
		public void UnPackTo(IVisualNovelRoleConfigT _o)
		{
			_o.Expression = this.Expression;
			_o.VisualEffect = this.VisualEffect;
			_o.HideAvatar = this.HideAvatar;
			_o.HidePortrait = this.HidePortrait;
			_o.CustomLayer = this.CustomLayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A3A2 RID: 238498 RVA: 0x007D8F80 File Offset: 0x007D7180
		public static Offset<IVisualNovelRoleConfig> Pack(FlatBufferBuilder builder, IVisualNovelRoleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleConfig>);
			}
			return IVisualNovelRoleConfig.CreateIVisualNovelRoleConfig(builder, _o.Expression, _o.VisualEffect, _o.HideAvatar, _o.HidePortrait, _o.CustomLayer, _o.NullMask);
		}

		// Token: 0x04013572 RID: 79218
		private Table __p;
	}
}
