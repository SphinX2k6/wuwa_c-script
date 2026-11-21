using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200792C RID: 31020
	public struct ISoar2 : IFlatbufferObject
	{
		// Token: 0x1700E390 RID: 58256
		// (get) Token: 0x06036A08 RID: 223752 RVA: 0x0074F691 File Offset: 0x0074D891
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A09 RID: 223753 RVA: 0x0074F69E File Offset: 0x0074D89E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A0A RID: 223754 RVA: 0x0074F6A8 File Offset: 0x0074D8A8
		public static ISoar2 GetRootAsISoar2(ByteBuffer _bb)
		{
			return ISoar2.GetRootAsISoar2(_bb, default(ISoar2));
		}

		// Token: 0x06036A0B RID: 223755 RVA: 0x0074F6C4 File Offset: 0x0074D8C4
		public static ISoar2 GetRootAsISoar2(ByteBuffer _bb, ISoar2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A0C RID: 223756 RVA: 0x0074F6E1 File Offset: 0x0074D8E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A0D RID: 223757 RVA: 0x0074F6F0 File Offset: 0x0074D8F0
		public ISoar2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E391 RID: 58257
		// (get) Token: 0x06036A0E RID: 223758 RVA: 0x0074F700 File Offset: 0x0074D900
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A0F RID: 223759 RVA: 0x0074F73C File Offset: 0x0074D93C
		public static Offset<ISoar2> CreateISoar2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISoar2.AddType(builder, Type);
			return ISoar2.EndISoar2(builder);
		}

		// Token: 0x06036A10 RID: 223760 RVA: 0x0074F752 File Offset: 0x0074D952
		public static void StartISoar2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036A11 RID: 223761 RVA: 0x0074F75B File Offset: 0x0074D95B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A12 RID: 223762 RVA: 0x0074F766 File Offset: 0x0074D966
		public static Offset<ISoar2> EndISoar2(FlatBufferBuilder builder)
		{
			return new Offset<ISoar2>(builder.EndTable());
		}

		// Token: 0x06036A13 RID: 223763 RVA: 0x0074F774 File Offset: 0x0074D974
		public ISoar2T UnPack()
		{
			ISoar2T soar2T = new ISoar2T();
			this.UnPackTo(soar2T);
			return soar2T;
		}

		// Token: 0x06036A14 RID: 223764 RVA: 0x0074F78F File Offset: 0x0074D98F
		public void UnPackTo(ISoar2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036A15 RID: 223765 RVA: 0x0074F7A0 File Offset: 0x0074D9A0
		public static Offset<ISoar2> Pack(FlatBufferBuilder builder, ISoar2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoar2>);
			}
			return ISoar2.CreateISoar2(builder, _o.Type);
		}

		// Token: 0x04012BF4 RID: 76788
		private Table __p;
	}
}
