using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CC RID: 716
	public sealed class ConditionInfo : IMessage<ConditionInfo>, IMessage, IEquatable<ConditionInfo>, IDeepCloneable<ConditionInfo>, IBufferMessage
	{
		// Token: 0x06004976 RID: 18806 RVA: 0x000B3CA8 File Offset: 0x000B1EA8
		[NullableContext(1)]
		public static ConditionInfo Create()
		{
			return new ConditionInfo();
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x000B3CAF File Offset: 0x000B1EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionInfo> Parser
		{
			get
			{
				return ConditionInfo._parser;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x000B3CB6 File Offset: 0x000B1EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06004979 RID: 18809 RVA: 0x000B3CB9 File Offset: 0x000B1EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionInfo.Descriptor;
			}
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x000B3CC0 File Offset: 0x000B1EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo()
		{
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x000B3CD3 File Offset: 0x000B1ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo(ConditionInfo other) : this()
		{
			this.finishConditionMap_ = other.finishConditionMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x000B3CFD File Offset: 0x000B1EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionInfo Clone()
		{
			return new ConditionInfo(this);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x000B3D05 File Offset: 0x000B1F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionItem> FinishConditionMap
		{
			get
			{
				return this.finishConditionMap_;
			}
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x000B3D0D File Offset: 0x000B1F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionInfo);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x000B3D1B File Offset: 0x000B1F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionInfo other)
		{
			return other != null && (other == this || (this.FinishConditionMap.Equals(other.FinishConditionMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x000B3D50 File Offset: 0x000B1F50
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

		// Token: 0x06004981 RID: 18817 RVA: 0x000B3D84 File Offset: 0x000B1F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x000B3D91 File Offset: 0x000B1F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x000B3D9A File Offset: 0x000B1F9A
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

		// Token: 0x06004984 RID: 18820 RVA: 0x000B3DC4 File Offset: 0x000B1FC4
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

		// Token: 0x06004985 RID: 18821 RVA: 0x000B3DFD File Offset: 0x000B1FFD
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

		// Token: 0x06004986 RID: 18822 RVA: 0x000B3E2B File Offset: 0x000B202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x000B3E34 File Offset: 0x000B2034
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

		// Token: 0x04003030 RID: 12336
		private static readonly MessageParser<ConditionInfo> _parser = new MessageParser<ConditionInfo>(() => new ConditionInfo());

		// Token: 0x04003031 RID: 12337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003032 RID: 12338
		public const int FinishConditionMapFieldNumber = 2;

		// Token: 0x04003033 RID: 12339
		private static readonly MapField<int, ConditionItem>.Codec _map_finishConditionMap_codec = new MapField<int, ConditionItem>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionItem>(18U, ConditionItem.Parser), 18U);

		// Token: 0x04003034 RID: 12340
		private readonly MapField<int, ConditionItem> finishConditionMap_ = new MapField<int, ConditionItem>();
	}
}
