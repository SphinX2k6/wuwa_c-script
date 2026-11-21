using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D1 RID: 721
	[NetMessage(EMessageId.ConditionGroupStateRequest)]
	public sealed class ConditionGroupStateRequest : IMessage<ConditionGroupStateRequest>, IMessage, IEquatable<ConditionGroupStateRequest>, IDeepCloneable<ConditionGroupStateRequest>, IBufferMessage
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x000B5B31 File Offset: 0x000B3D31
		[NullableContext(1)]
		public static ConditionGroupStateRequest Create()
		{
			return new ConditionGroupStateRequest();
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x000B5B38 File Offset: 0x000B3D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x000B5B3B File Offset: 0x000B3D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupStateRequest.Descriptor;
			}
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x000B5B42 File Offset: 0x000B3D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest()
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x000B5B55 File Offset: 0x000B3D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest(ConditionGroupStateRequest other) : this()
		{
			this.conditionModule_ = other.conditionModule_;
			this.conditionGroupIds_ = other.conditionGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x000B5B8B File Offset: 0x000B3D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest Clone()
		{
			return new ConditionGroupStateRequest(this);
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x000B5B93 File Offset: 0x000B3D93
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x000B5B9B File Offset: 0x000B3D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionModule
		{
			get
			{
				return this.conditionModule_;
			}
			set
			{
				this.conditionModule_ = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x000B5BA4 File Offset: 0x000B3DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionGroupIds
		{
			get
			{
				return this.conditionGroupIds_;
			}
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x000B5BAC File Offset: 0x000B3DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupStateRequest);
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x000B5BBC File Offset: 0x000B3DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupStateRequest other)
		{
			return other != null && (other == this || (this.ConditionModule == other.ConditionModule && this.conditionGroupIds_.Equals(other.conditionGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x000B5C0C File Offset: 0x000B3E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionModule != 0)
			{
				num ^= this.ConditionModule.GetHashCode();
			}
			num ^= this.conditionGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x000B5C59 File Offset: 0x000B3E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x000B5C66 File Offset: 0x000B3E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x000B5C70 File Offset: 0x000B3E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionModule != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConditionModule);
			}
			this.conditionGroupIds_.WriteTo(ref output, ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x000B5CC0 File Offset: 0x000B3EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionModule != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionModule);
			}
			num += this.conditionGroupIds_.CalculateSize(ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x000B5D14 File Offset: 0x000B3F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionModule != 0)
			{
				this.ConditionModule = other.ConditionModule;
			}
			this.conditionGroupIds_.Add(other.conditionGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x000B5D61 File Offset: 0x000B3F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x000B5D6C File Offset: 0x000B3F6C
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
				if (num != 56U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.conditionGroupIds_.AddEntriesFrom(ref input, ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
					}
				}
				else
				{
					this.ConditionModule = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030BB RID: 12475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030BC RID: 12476
		public const int ConditionModuleFieldNumber = 7;

		// Token: 0x040030BD RID: 12477
		private int conditionModule_;

		// Token: 0x040030BE RID: 12478
		public const int ConditionGroupIdsFieldNumber = 11;

		// Token: 0x040030BF RID: 12479
		private static readonly FieldCodec<int> _repeated_conditionGroupIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040030C0 RID: 12480
		private readonly RepeatedField<int> conditionGroupIds_ = new RepeatedField<int>();
	}
}
