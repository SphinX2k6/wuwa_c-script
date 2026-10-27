using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A8 RID: 29096
	public struct IStandControl : IFlatbufferObject
	{
		// Token: 0x1700D816 RID: 55318
		// (get) Token: 0x06033966 RID: 211302 RVA: 0x006F283D File Offset: 0x006F0A3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033967 RID: 211303 RVA: 0x006F284A File Offset: 0x006F0A4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033968 RID: 211304 RVA: 0x006F2854 File Offset: 0x006F0A54
		public static IStandControl GetRootAsIStandControl(ByteBuffer _bb)
		{
			return IStandControl.GetRootAsIStandControl(_bb, default(IStandControl));
		}

		// Token: 0x06033969 RID: 211305 RVA: 0x006F2870 File Offset: 0x006F0A70
		public static IStandControl GetRootAsIStandControl(ByteBuffer _bb, IStandControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603396A RID: 211306 RVA: 0x006F288D File Offset: 0x006F0A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603396B RID: 211307 RVA: 0x006F289C File Offset: 0x006F0A9C
		public IStandControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D817 RID: 55319
		// (get) Token: 0x0603396C RID: 211308 RVA: 0x006F28AC File Offset: 0x006F0AAC
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

		// Token: 0x0603396D RID: 211309 RVA: 0x006F28E8 File Offset: 0x006F0AE8
		public static Offset<IStandControl> CreateIStandControl(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IStandControl.AddType(builder, Type);
			return IStandControl.EndIStandControl(builder);
		}

		// Token: 0x0603396E RID: 211310 RVA: 0x006F28FE File Offset: 0x006F0AFE
		public static void StartIStandControl(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603396F RID: 211311 RVA: 0x006F2907 File Offset: 0x006F0B07
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033970 RID: 211312 RVA: 0x006F2912 File Offset: 0x006F0B12
		public static Offset<IStandControl> EndIStandControl(FlatBufferBuilder builder)
		{
			return new Offset<IStandControl>(builder.EndTable());
		}

		// Token: 0x06033971 RID: 211313 RVA: 0x006F2920 File Offset: 0x006F0B20
		public IStandControlT UnPack()
		{
			IStandControlT standControlT = new IStandControlT();
			this.UnPackTo(standControlT);
			return standControlT;
		}

		// Token: 0x06033972 RID: 211314 RVA: 0x006F293B File Offset: 0x006F0B3B
		public void UnPackTo(IStandControlT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033973 RID: 211315 RVA: 0x006F294C File Offset: 0x006F0B4C
		public static Offset<IStandControl> Pack(FlatBufferBuilder builder, IStandControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStandControl>);
			}
			return IStandControl.CreateIStandControl(builder, _o.Type);
		}

		// Token: 0x04011C71 RID: 72817
		private Table __p;
	}
}
