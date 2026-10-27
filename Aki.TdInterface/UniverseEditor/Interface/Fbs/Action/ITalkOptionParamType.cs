using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007331 RID: 29489
	public struct ITalkOptionParamType : IFlatbufferObject
	{
		// Token: 0x1700DFFE RID: 57342
		// (get) Token: 0x0603583E RID: 219198 RVA: 0x0074A5AD File Offset: 0x007487AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603583F RID: 219199 RVA: 0x0074A5BA File Offset: 0x007487BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035840 RID: 219200 RVA: 0x0074A5C4 File Offset: 0x007487C4
		public static ITalkOptionParamType GetRootAsITalkOptionParamType(ByteBuffer _bb)
		{
			return ITalkOptionParamType.GetRootAsITalkOptionParamType(_bb, default(ITalkOptionParamType));
		}

		// Token: 0x06035841 RID: 219201 RVA: 0x0074A5E0 File Offset: 0x007487E0
		public static ITalkOptionParamType GetRootAsITalkOptionParamType(ByteBuffer _bb, ITalkOptionParamType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035842 RID: 219202 RVA: 0x0074A5FD File Offset: 0x007487FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035843 RID: 219203 RVA: 0x0074A60C File Offset: 0x0074880C
		public ITalkOptionParamType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFFF RID: 57343
		// (get) Token: 0x06035844 RID: 219204 RVA: 0x0074A61C File Offset: 0x0074881C
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035845 RID: 219205 RVA: 0x0074A658 File Offset: 0x00748858
		public static Offset<ITalkOptionParamType> CreateITalkOptionParamType(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionParamType.AddType(builder, Type);
			return ITalkOptionParamType.EndITalkOptionParamType(builder);
		}

		// Token: 0x06035846 RID: 219206 RVA: 0x0074A66E File Offset: 0x0074886E
		public static void StartITalkOptionParamType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035847 RID: 219207 RVA: 0x0074A677 File Offset: 0x00748877
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035848 RID: 219208 RVA: 0x0074A682 File Offset: 0x00748882
		public static Offset<ITalkOptionParamType> EndITalkOptionParamType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionParamType>(builder.EndTable());
		}

		// Token: 0x06035849 RID: 219209 RVA: 0x0074A690 File Offset: 0x00748890
		public ITalkOptionParamTypeT UnPack()
		{
			ITalkOptionParamTypeT talkOptionParamTypeT = new ITalkOptionParamTypeT();
			this.UnPackTo(talkOptionParamTypeT);
			return talkOptionParamTypeT;
		}

		// Token: 0x0603584A RID: 219210 RVA: 0x0074A6AB File Offset: 0x007488AB
		public void UnPackTo(ITalkOptionParamTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603584B RID: 219211 RVA: 0x0074A6BC File Offset: 0x007488BC
		public static Offset<ITalkOptionParamType> Pack(FlatBufferBuilder builder, ITalkOptionParamTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionParamType>);
			}
			return ITalkOptionParamType.CreateITalkOptionParamType(builder, _o.Type);
		}

		// Token: 0x0401211E RID: 74014
		private Table __p;
	}
}
