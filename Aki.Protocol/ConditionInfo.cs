using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D3 RID: 723
	public sealed class ConditionInfo : IMessage<ConditionInfo>, IMessage, IEquatable<ConditionInfo>, IDeepCloneable<ConditionInfo>, IBufferMessage
	{
		// Token: 0x06004A4F RID: 19023 RVA: 0x000B6090 File Offset: 0x000B4290
		[NullableContext(1)]
		public static ConditionInfo Create()
		{
			return new ConditionInfo();
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x000B6097 File Offset: 0x000B4297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionInfo> Parser
		{
			get
			{
				return ConditionInfo._parser;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x000B609E File Offset: 0x000B429E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x000B60A1 File Offset: 0x000B42A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionInfo.Descriptor;
			}
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x000B60A8 File Offset: 0x000B42A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo()
		{
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x000B60BB File Offset: 0x000B42BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo(ConditionInfo other) : this()
		{
			this.finishConditionMap_ = other.finishConditionMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x000B60E5 File Offset: 0x000B42E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo Clone()
		{
			return new ConditionInfo(this);
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x000B60ED File Offset: 0x000B42ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionItem> FinishConditionMap
		{
			get
			{
				return this.finishConditionMap_;
			}
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x000B60F5 File Offset: 0x000B42F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionInfo);
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x000B6103 File Offset: 0x000B4303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionInfo other)
		{
			return other != null && (other == this || (this.FinishConditionMap.Equals(other.FinishConditionMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x000B6138 File Offset: 0x000B4338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.FinishConditionMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x000B616C File Offset: 0x000B436C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x000B6179 File Offset: 0x000B4379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x000B6182 File Offset: 0x000B4382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finishConditionMap_.WriteTo(ref output, ConditionInfo._map_finishConditionMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x000B61AC File Offset: 0x000B43AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.finishConditionMap_.CalculateSize(ConditionInfo._map_finishConditionMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x000B61E5 File Offset: 0x000B43E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.finishConditionMap_.MergeFrom(other.finishConditionMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x000B6213 File Offset: 0x000B4413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x000B621C File Offset: 0x000B441C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.finishConditionMap_.AddEntriesFrom(ref input, ConditionInfo._map_finishConditionMap_codec);
				}
			}
		}

		// Token: 0x040030C7 RID: 12487
		private static readonly MessageParser<ConditionInfo> _parser = new MessageParser<ConditionInfo>(() => new ConditionInfo());

		// Token: 0x040030C8 RID: 12488
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030C9 RID: 12489
		public const int FinishConditionMapFieldNumber = 2;

		// Token: 0x040030CA RID: 12490
		private static readonly MapField<int, ConditionItem>.Codec _map_finishConditionMap_codec = new MapField<int, ConditionItem>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionItem>(18U, ConditionItem.Parser), 18U);

		// Token: 0x040030CB RID: 12491
		private readonly MapField<int, ConditionItem> finishConditionMap_ = new MapField<int, ConditionItem>();
	}
}
