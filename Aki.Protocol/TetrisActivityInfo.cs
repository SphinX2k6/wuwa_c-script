using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C5 RID: 5061
	public sealed class TetrisActivityInfo : IMessage<TetrisActivityInfo>, IMessage, IEquatable<TetrisActivityInfo>, IDeepCloneable<TetrisActivityInfo>, IBufferMessage
	{
		// Token: 0x0601AEFB RID: 110331 RVA: 0x003EC82A File Offset: 0x003EAA2A
		[NullableContext(1)]
		public static TetrisActivityInfo Create()
		{
			return new TetrisActivityInfo();
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x0601AEFC RID: 110332 RVA: 0x003EC831 File Offset: 0x003EAA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0601AEFD RID: 110333 RVA: 0x003EC834 File Offset: 0x003EAA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601AEFE RID: 110334 RVA: 0x003EC83B File Offset: 0x003EAA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo()
		{
		}

		// Token: 0x0601AEFF RID: 110335 RVA: 0x003EC84E File Offset: 0x003EAA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo(TetrisActivityInfo other) : this()
		{
			this.tetrisLevelInfos_ = other.tetrisLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF00 RID: 110336 RVA: 0x003EC878 File Offset: 0x003EAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo Clone()
		{
			return new TetrisActivityInfo(this);
		}

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x0601AF01 RID: 110337 RVA: 0x003EC880 File Offset: 0x003EAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TetrisLevelInfo> TetrisLevelInfos
		{
			get
			{
				return this.tetrisLevelInfos_;
			}
		}

		// Token: 0x0601AF02 RID: 110338 RVA: 0x003EC888 File Offset: 0x003EAA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisActivityInfo);
		}

		// Token: 0x0601AF03 RID: 110339 RVA: 0x003EC896 File Offset: 0x003EAA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisActivityInfo other)
		{
			return other != null && (other == this || (this.tetrisLevelInfos_.Equals(other.tetrisLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF04 RID: 110340 RVA: 0x003EC8CC File Offset: 0x003EAACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tetrisLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF05 RID: 110341 RVA: 0x003EC900 File Offset: 0x003EAB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF06 RID: 110342 RVA: 0x003EC90D File Offset: 0x003EAB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF07 RID: 110343 RVA: 0x003EC916 File Offset: 0x003EAB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tetrisLevelInfos_.WriteTo(ref output, TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF08 RID: 110344 RVA: 0x003EC940 File Offset: 0x003EAB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tetrisLevelInfos_.CalculateSize(TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF09 RID: 110345 RVA: 0x003EC979 File Offset: 0x003EAB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.tetrisLevelInfos_.Add(other.tetrisLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF0A RID: 110346 RVA: 0x003EC9A7 File Offset: 0x003EABA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF0B RID: 110347 RVA: 0x003EC9B0 File Offset: 0x003EABB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.tetrisLevelInfos_.AddEntriesFrom(ref input, TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
				}
			}
		}

		// Token: 0x04009D85 RID: 40325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D86 RID: 40326
		public const int TetrisLevelInfosFieldNumber = 1;

		// Token: 0x04009D87 RID: 40327
		private static readonly FieldCodec<TetrisLevelInfo> _repeated_tetrisLevelInfos_codec = FieldCodec.ForMessage<TetrisLevelInfo>(10U, TetrisLevelInfo.Parser);

		// Token: 0x04009D88 RID: 40328
		private readonly RepeatedField<TetrisLevelInfo> tetrisLevelInfos_ = new RepeatedField<TetrisLevelInfo>();
	}
}
