using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C79 RID: 19577
	public struct IPhotographCameraCheckType : IFlatbufferObject
	{
		// Token: 0x17008E31 RID: 36401
		// (get) Token: 0x0601F0BB RID: 127163 RVA: 0x00456EFE File Offset: 0x004550FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0BC RID: 127164 RVA: 0x00456F0B File Offset: 0x0045510B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0BD RID: 127165 RVA: 0x00456F14 File Offset: 0x00455114
		public static IPhotographCameraCheckType GetRootAsIPhotographCameraCheckType(ByteBuffer _bb)
		{
			return IPhotographCameraCheckType.GetRootAsIPhotographCameraCheckType(_bb, default(IPhotographCameraCheckType));
		}

		// Token: 0x0601F0BE RID: 127166 RVA: 0x00456F30 File Offset: 0x00455130
		public static IPhotographCameraCheckType GetRootAsIPhotographCameraCheckType(ByteBuffer _bb, IPhotographCameraCheckType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0BF RID: 127167 RVA: 0x00456F4D File Offset: 0x0045514D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0C0 RID: 127168 RVA: 0x00456F5C File Offset: 0x0045515C
		public IPhotographCameraCheckType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E32 RID: 36402
		// (get) Token: 0x0601F0C1 RID: 127169 RVA: 0x00456F6C File Offset: 0x0045516C
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F0C2 RID: 127170 RVA: 0x00456FA8 File Offset: 0x004551A8
		public static Offset<IPhotographCameraCheckType> CreateIPhotographCameraCheckType(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate)
		{
			builder.StartTable(1);
			IPhotographCameraCheckType.AddType(builder, Type);
			return IPhotographCameraCheckType.EndIPhotographCameraCheckType(builder);
		}

		// Token: 0x0601F0C3 RID: 127171 RVA: 0x00456FBE File Offset: 0x004551BE
		public static void StartIPhotographCameraCheckType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F0C4 RID: 127172 RVA: 0x00456FC7 File Offset: 0x004551C7
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F0C5 RID: 127173 RVA: 0x00456FD2 File Offset: 0x004551D2
		public static Offset<IPhotographCameraCheckType> EndIPhotographCameraCheckType(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckType>(builder.EndTable());
		}

		// Token: 0x0601F0C6 RID: 127174 RVA: 0x00456FE0 File Offset: 0x004551E0
		public IPhotographCameraCheckTypeT UnPack()
		{
			IPhotographCameraCheckTypeT photographCameraCheckTypeT = new IPhotographCameraCheckTypeT();
			this.UnPackTo(photographCameraCheckTypeT);
			return photographCameraCheckTypeT;
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x00456FFB File Offset: 0x004551FB
		public void UnPackTo(IPhotographCameraCheckTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F0C8 RID: 127176 RVA: 0x0045700C File Offset: 0x0045520C
		public static Offset<IPhotographCameraCheckType> Pack(FlatBufferBuilder builder, IPhotographCameraCheckTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckType>);
			}
			return IPhotographCameraCheckType.CreateIPhotographCameraCheckType(builder, _o.Type);
		}

		// Token: 0x0400D62B RID: 54827
		private Table __p;
	}
}
