using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007124 RID: 28964
	public struct ILiveSendScConfig : IFlatbufferObject
	{
		// Token: 0x1700D418 RID: 54296
		// (get) Token: 0x060324FF RID: 206079 RVA: 0x006CD6EC File Offset: 0x006CB8EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032500 RID: 206080 RVA: 0x006CD6F9 File Offset: 0x006CB8F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032501 RID: 206081 RVA: 0x006CD700 File Offset: 0x006CB900
		public static ILiveSendScConfig GetRootAsILiveSendScConfig(ByteBuffer _bb)
		{
			return ILiveSendScConfig.GetRootAsILiveSendScConfig(_bb, default(ILiveSendScConfig));
		}

		// Token: 0x06032502 RID: 206082 RVA: 0x006CD71C File Offset: 0x006CB91C
		public static ILiveSendScConfig GetRootAsILiveSendScConfig(ByteBuffer _bb, ILiveSendScConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032503 RID: 206083 RVA: 0x006CD739 File Offset: 0x006CB939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032504 RID: 206084 RVA: 0x006CD748 File Offset: 0x006CB948
		public ILiveSendScConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D419 RID: 54297
		// (get) Token: 0x06032505 RID: 206085 RVA: 0x006CD758 File Offset: 0x006CB958
		public ELiveScOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveScOperationType.Send;
				}
				return (ELiveScOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032506 RID: 206086 RVA: 0x006CD794 File Offset: 0x006CB994
		public ILiveScConfig? ScList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILiveScConfig?(default(ILiveScConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D41A RID: 54298
		// (get) Token: 0x06032507 RID: 206087 RVA: 0x006CD7F4 File Offset: 0x006CB9F4
		public int ScListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032508 RID: 206088 RVA: 0x006CD81F File Offset: 0x006CBA1F
		public static Offset<ILiveSendScConfig> CreateILiveSendScConfig(FlatBufferBuilder builder, ELiveScOperationType Type = ELiveScOperationType.Send, VectorOffset ScListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILiveSendScConfig.AddScList(builder, ScListOffset);
			ILiveSendScConfig.AddType(builder, Type);
			return ILiveSendScConfig.EndILiveSendScConfig(builder);
		}

		// Token: 0x06032509 RID: 206089 RVA: 0x006CD83C File Offset: 0x006CBA3C
		public static void StartILiveSendScConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603250A RID: 206090 RVA: 0x006CD845 File Offset: 0x006CBA45
		public static void AddType(FlatBufferBuilder builder, ELiveScOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603250B RID: 206091 RVA: 0x006CD850 File Offset: 0x006CBA50
		public static void AddScList(FlatBufferBuilder builder, VectorOffset scListOffset)
		{
			builder.AddOffset(1, scListOffset.Value, 0);
		}

		// Token: 0x0603250C RID: 206092 RVA: 0x006CD860 File Offset: 0x006CBA60
		public static VectorOffset CreateScListVector(FlatBufferBuilder builder, Offset<ILiveScConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603250D RID: 206093 RVA: 0x006CD8A0 File Offset: 0x006CBAA0
		public static VectorOffset CreateScListVectorBlock(FlatBufferBuilder builder, Offset<ILiveScConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILiveScConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603250E RID: 206094 RVA: 0x006CD8BA File Offset: 0x006CBABA
		public static VectorOffset CreateScListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILiveScConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILiveScConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603250F RID: 206095 RVA: 0x006CD8D8 File Offset: 0x006CBAD8
		public static VectorOffset CreateScListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILiveScConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032510 RID: 206096 RVA: 0x006CD8F1 File Offset: 0x006CBAF1
		public static void StartScListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032511 RID: 206097 RVA: 0x006CD8FC File Offset: 0x006CBAFC
		public static Offset<ILiveSendScConfig> EndILiveSendScConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveSendScConfig>(builder.EndTable());
		}

		// Token: 0x06032512 RID: 206098 RVA: 0x006CD90C File Offset: 0x006CBB0C
		public ILiveSendScConfigT UnPack()
		{
			ILiveSendScConfigT liveSendScConfigT = new ILiveSendScConfigT();
			this.UnPackTo(liveSendScConfigT);
			return liveSendScConfigT;
		}

		// Token: 0x06032513 RID: 206099 RVA: 0x006CD928 File Offset: 0x006CBB28
		public void UnPackTo(ILiveSendScConfigT _o)
		{
			_o.Type = this.Type;
			_o.ScList = new List<ILiveScConfigT>();
			for (int i = 0; i < this.ScListLength; i++)
			{
				_o.ScList.Add((this.ScList(i) != null) ? this.ScList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032514 RID: 206100 RVA: 0x006CD994 File Offset: 0x006CBB94
		public static Offset<ILiveSendScConfig> Pack(FlatBufferBuilder builder, ILiveSendScConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveSendScConfig>);
			}
			VectorOffset scListOffset = default(VectorOffset);
			if (_o.ScList != null)
			{
				Offset<ILiveScConfig>[] array = new Offset<ILiveScConfig>[_o.ScList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILiveScConfig.Pack(builder, _o.ScList[i]);
				}
				scListOffset = ILiveSendScConfig.CreateScListVector(builder, array);
			}
			return ILiveSendScConfig.CreateILiveSendScConfig(builder, _o.Type, scListOffset);
		}

		// Token: 0x0401210C RID: 73996
		private Table __p;
	}
}
