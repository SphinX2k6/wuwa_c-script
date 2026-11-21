using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CE RID: 17870
	public struct ITakePhoto2ModeBase : IFlatbufferObject
	{
		// Token: 0x17007CFD RID: 31997
		// (get) Token: 0x0601A191 RID: 106897 RVA: 0x003B82C9 File Offset: 0x003B64C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A192 RID: 106898 RVA: 0x003B82D6 File Offset: 0x003B64D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A193 RID: 106899 RVA: 0x003B82E0 File Offset: 0x003B64E0
		public static ITakePhoto2ModeBase GetRootAsITakePhoto2ModeBase(ByteBuffer _bb)
		{
			return ITakePhoto2ModeBase.GetRootAsITakePhoto2ModeBase(_bb, default(ITakePhoto2ModeBase));
		}

		// Token: 0x0601A194 RID: 106900 RVA: 0x003B82FC File Offset: 0x003B64FC
		public static ITakePhoto2ModeBase GetRootAsITakePhoto2ModeBase(ByteBuffer _bb, ITakePhoto2ModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A195 RID: 106901 RVA: 0x003B8319 File Offset: 0x003B6519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A196 RID: 106902 RVA: 0x003B8328 File Offset: 0x003B6528
		public ITakePhoto2ModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CFE RID: 31998
		// (get) Token: 0x0601A197 RID: 106903 RVA: 0x003B8338 File Offset: 0x003B6538
		public ETakePhoto2Mode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2Mode.BeforeYourEyes;
				}
				return (ETakePhoto2Mode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A198 RID: 106904 RVA: 0x003B8374 File Offset: 0x003B6574
		public static Offset<ITakePhoto2ModeBase> CreateITakePhoto2ModeBase(FlatBufferBuilder builder, ETakePhoto2Mode Type = ETakePhoto2Mode.BeforeYourEyes)
		{
			builder.StartTable(1);
			ITakePhoto2ModeBase.AddType(builder, Type);
			return ITakePhoto2ModeBase.EndITakePhoto2ModeBase(builder);
		}

		// Token: 0x0601A199 RID: 106905 RVA: 0x003B838A File Offset: 0x003B658A
		public static void StartITakePhoto2ModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A19A RID: 106906 RVA: 0x003B8393 File Offset: 0x003B6593
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2Mode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A19B RID: 106907 RVA: 0x003B839E File Offset: 0x003B659E
		public static Offset<ITakePhoto2ModeBase> EndITakePhoto2ModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2ModeBase>(builder.EndTable());
		}

		// Token: 0x0601A19C RID: 106908 RVA: 0x003B83AC File Offset: 0x003B65AC
		public ITakePhoto2ModeBaseT UnPack()
		{
			ITakePhoto2ModeBaseT takePhoto2ModeBaseT = new ITakePhoto2ModeBaseT();
			this.UnPackTo(takePhoto2ModeBaseT);
			return takePhoto2ModeBaseT;
		}

		// Token: 0x0601A19D RID: 106909 RVA: 0x003B83C7 File Offset: 0x003B65C7
		public void UnPackTo(ITakePhoto2ModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A19E RID: 106910 RVA: 0x003B83D8 File Offset: 0x003B65D8
		public static Offset<ITakePhoto2ModeBase> Pack(FlatBufferBuilder builder, ITakePhoto2ModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2ModeBase>);
			}
			return ITakePhoto2ModeBase.CreateITakePhoto2ModeBase(builder, _o.Type);
		}

		// Token: 0x0400C7A6 RID: 51110
		private Table __p;
	}
}
