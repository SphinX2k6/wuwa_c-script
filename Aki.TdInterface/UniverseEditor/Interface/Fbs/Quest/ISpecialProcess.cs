using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413C RID: 16700
	public struct ISpecialProcess : IFlatbufferObject
	{
		// Token: 0x17007646 RID: 30278
		// (get) Token: 0x060187E2 RID: 100322 RVA: 0x00387D98 File Offset: 0x00385F98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187E3 RID: 100323 RVA: 0x00387DA5 File Offset: 0x00385FA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187E4 RID: 100324 RVA: 0x00387DAC File Offset: 0x00385FAC
		public static ISpecialProcess GetRootAsISpecialProcess(ByteBuffer _bb)
		{
			return ISpecialProcess.GetRootAsISpecialProcess(_bb, default(ISpecialProcess));
		}

		// Token: 0x060187E5 RID: 100325 RVA: 0x00387DC8 File Offset: 0x00385FC8
		public static ISpecialProcess GetRootAsISpecialProcess(ByteBuffer _bb, ISpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187E6 RID: 100326 RVA: 0x00387DE5 File Offset: 0x00385FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187E7 RID: 100327 RVA: 0x00387DF4 File Offset: 0x00385FF4
		public ISpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007647 RID: 30279
		// (get) Token: 0x060187E8 RID: 100328 RVA: 0x00387E04 File Offset: 0x00386004
		public ESpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialProcess.LowMemorySceneSwitch;
				}
				return (ESpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060187E9 RID: 100329 RVA: 0x00387E40 File Offset: 0x00386040
		public static Offset<ISpecialProcess> CreateISpecialProcess(FlatBufferBuilder builder, ESpecialProcess Type = ESpecialProcess.LowMemorySceneSwitch)
		{
			builder.StartTable(1);
			ISpecialProcess.AddType(builder, Type);
			return ISpecialProcess.EndISpecialProcess(builder);
		}

		// Token: 0x060187EA RID: 100330 RVA: 0x00387E56 File Offset: 0x00386056
		public static void StartISpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060187EB RID: 100331 RVA: 0x00387E5F File Offset: 0x0038605F
		public static void AddType(FlatBufferBuilder builder, ESpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060187EC RID: 100332 RVA: 0x00387E6A File Offset: 0x0038606A
		public static Offset<ISpecialProcess> EndISpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialProcess>(builder.EndTable());
		}

		// Token: 0x060187ED RID: 100333 RVA: 0x00387E78 File Offset: 0x00386078
		public ISpecialProcessT UnPack()
		{
			ISpecialProcessT specialProcessT = new ISpecialProcessT();
			this.UnPackTo(specialProcessT);
			return specialProcessT;
		}

		// Token: 0x060187EE RID: 100334 RVA: 0x00387E93 File Offset: 0x00386093
		public void UnPackTo(ISpecialProcessT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060187EF RID: 100335 RVA: 0x00387EA4 File Offset: 0x003860A4
		public static Offset<ISpecialProcess> Pack(FlatBufferBuilder builder, ISpecialProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialProcess>);
			}
			return ISpecialProcess.CreateISpecialProcess(builder, _o.Type);
		}

		// Token: 0x0400BD44 RID: 48452
		private Table __p;
	}
}
