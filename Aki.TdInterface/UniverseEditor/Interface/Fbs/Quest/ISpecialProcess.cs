using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200457D RID: 17789
	public struct ISpecialProcess : IFlatbufferObject
	{
		// Token: 0x17007C4C RID: 31820
		// (get) Token: 0x06019E85 RID: 106117 RVA: 0x003B1DA0 File Offset: 0x003AFFA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E86 RID: 106118 RVA: 0x003B1DAD File Offset: 0x003AFFAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E87 RID: 106119 RVA: 0x003B1DB4 File Offset: 0x003AFFB4
		public static ISpecialProcess GetRootAsISpecialProcess(ByteBuffer _bb)
		{
			return ISpecialProcess.GetRootAsISpecialProcess(_bb, default(ISpecialProcess));
		}

		// Token: 0x06019E88 RID: 106120 RVA: 0x003B1DD0 File Offset: 0x003AFFD0
		public static ISpecialProcess GetRootAsISpecialProcess(ByteBuffer _bb, ISpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E89 RID: 106121 RVA: 0x003B1DED File Offset: 0x003AFFED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E8A RID: 106122 RVA: 0x003B1DFC File Offset: 0x003AFFFC
		public ISpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C4D RID: 31821
		// (get) Token: 0x06019E8B RID: 106123 RVA: 0x003B1E0C File Offset: 0x003B000C
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

		// Token: 0x06019E8C RID: 106124 RVA: 0x003B1E48 File Offset: 0x003B0048
		public static Offset<ISpecialProcess> CreateISpecialProcess(FlatBufferBuilder builder, ESpecialProcess Type = ESpecialProcess.LowMemorySceneSwitch)
		{
			builder.StartTable(1);
			ISpecialProcess.AddType(builder, Type);
			return ISpecialProcess.EndISpecialProcess(builder);
		}

		// Token: 0x06019E8D RID: 106125 RVA: 0x003B1E5E File Offset: 0x003B005E
		public static void StartISpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019E8E RID: 106126 RVA: 0x003B1E67 File Offset: 0x003B0067
		public static void AddType(FlatBufferBuilder builder, ESpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E8F RID: 106127 RVA: 0x003B1E72 File Offset: 0x003B0072
		public static Offset<ISpecialProcess> EndISpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialProcess>(builder.EndTable());
		}

		// Token: 0x06019E90 RID: 106128 RVA: 0x003B1E80 File Offset: 0x003B0080
		public ISpecialProcessT UnPack()
		{
			ISpecialProcessT specialProcessT = new ISpecialProcessT();
			this.UnPackTo(specialProcessT);
			return specialProcessT;
		}

		// Token: 0x06019E91 RID: 106129 RVA: 0x003B1E9B File Offset: 0x003B009B
		public void UnPackTo(ISpecialProcessT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019E92 RID: 106130 RVA: 0x003B1EAC File Offset: 0x003B00AC
		public static Offset<ISpecialProcess> Pack(FlatBufferBuilder builder, ISpecialProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialProcess>);
			}
			return ISpecialProcess.CreateISpecialProcess(builder, _o.Type);
		}

		// Token: 0x0400C72D RID: 50989
		private Table __p;
	}
}
