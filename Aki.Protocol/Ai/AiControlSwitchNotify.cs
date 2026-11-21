using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001727 RID: 5927
	[NetMessage(EMessageId.AiControlSwitchNotify)]
	public sealed class AiControlSwitchNotify : IMessage<AiControlSwitchNotify>, IMessage, IEquatable<AiControlSwitchNotify>, IDeepCloneable<AiControlSwitchNotify>, IBufferMessage
	{
		// Token: 0x0601DC0C RID: 121868 RVA: 0x0045D369 File Offset: 0x0045B569
		[NullableContext(1)]
		public static AiControlSwitchNotify Create()
		{
			return new AiControlSwitchNotify();
		}

		// Token: 0x1700654E RID: 25934
		// (get) Token: 0x0601DC0D RID: 121869 RVA: 0x0045D370 File Offset: 0x0045B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700654F RID: 25935
		// (get) Token: 0x0601DC0E RID: 121870 RVA: 0x0045D373 File Offset: 0x0045B573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0601DC0F RID: 121871 RVA: 0x0045D37A File Offset: 0x0045B57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify()
		{
		}

		// Token: 0x0601DC10 RID: 121872 RVA: 0x0045D38D File Offset: 0x0045B58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify(AiControlSwitchNotify other) : this()
		{
			this.aiControlSwitchInfos_ = other.aiControlSwitchInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x0045D3B7 File Offset: 0x0045B5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify Clone()
		{
			return new AiControlSwitchNotify(this);
		}

		// Token: 0x17006550 RID: 25936
		// (get) Token: 0x0601DC12 RID: 121874 RVA: 0x0045D3BF File Offset: 0x0045B5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiControlSwitch> AiControlSwitchInfos
		{
			get
			{
				return this.aiControlSwitchInfos_;
			}
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x0045D3C7 File Offset: 0x0045B5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchNotify);
		}

		// Token: 0x0601DC14 RID: 121876 RVA: 0x0045D3D5 File Offset: 0x0045B5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchNotify other)
		{
			return other != null && (other == this || (this.aiControlSwitchInfos_.Equals(other.aiControlSwitchInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC15 RID: 121877 RVA: 0x0045D408 File Offset: 0x0045B608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiControlSwitchInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DC16 RID: 121878 RVA: 0x0045D43C File Offset: 0x0045B63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC17 RID: 121879 RVA: 0x0045D449 File Offset: 0x0045B649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC18 RID: 121880 RVA: 0x0045D452 File Offset: 0x0045B652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiControlSwitchInfos_.WriteTo(ref output, AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC19 RID: 121881 RVA: 0x0045D47C File Offset: 0x0045B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiControlSwitchInfos_.CalculateSize(AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC1A RID: 121882 RVA: 0x0045D4B5 File Offset: 0x0045B6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiControlSwitchInfos_.Add(other.aiControlSwitchInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC1B RID: 121883 RVA: 0x0045D4E3 File Offset: 0x0045B6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC1C RID: 121884 RVA: 0x0045D4EC File Offset: 0x0045B6EC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiControlSwitchInfos_.AddEntriesFrom(ref input, AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
				}
			}
		}

		// Token: 0x0400C95F RID: 51551
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C960 RID: 51552
		public const int AiControlSwitchInfosFieldNumber = 6;

		// Token: 0x0400C961 RID: 51553
		private static readonly FieldCodec<AiControlSwitch> _repeated_aiControlSwitchInfos_codec = FieldCodec.ForMessage<AiControlSwitch>(50U, AiControlSwitch.Parser);

		// Token: 0x0400C962 RID: 51554
		private readonly RepeatedField<AiControlSwitch> aiControlSwitchInfos_ = new RepeatedField<AiControlSwitch>();
	}
}
