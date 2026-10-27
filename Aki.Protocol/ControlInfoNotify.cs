using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EE RID: 750
	[NetMessage(EMessageId.ControlInfoNotify)]
	public sealed class ControlInfoNotify : IMessage<ControlInfoNotify>, IMessage, IEquatable<ControlInfoNotify>, IDeepCloneable<ControlInfoNotify>, IBufferMessage
	{
		// Token: 0x06004C1D RID: 19485 RVA: 0x000B946D File Offset: 0x000B766D
		[NullableContext(1)]
		public static ControlInfoNotify Create()
		{
			return new ControlInfoNotify();
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x000B9474 File Offset: 0x000B7674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x000B9477 File Offset: 0x000B7677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlInfoNotify.Descriptor;
			}
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x000B947E File Offset: 0x000B767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify()
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x000B9491 File Offset: 0x000B7691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify(ControlInfoNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x000B94BB File Offset: 0x000B76BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify Clone()
		{
			return new ControlInfoNotify(this);
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x000B94C3 File Offset: 0x000B76C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x000B94CB File Offset: 0x000B76CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlInfoNotify);
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x000B94D9 File Offset: 0x000B76D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlInfoNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x000B950C File Offset: 0x000B770C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.forbidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x000B9540 File Offset: 0x000B7740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x000B954D File Offset: 0x000B774D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x000B9556 File Offset: 0x000B7756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forbidList_.WriteTo(ref output, ControlInfoNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x000B9580 File Offset: 0x000B7780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forbidList_.CalculateSize(ControlInfoNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x000B95B9 File Offset: 0x000B77B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forbidList_.Add(other.forbidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x000B95E7 File Offset: 0x000B77E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x000B95F0 File Offset: 0x000B77F0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, ControlInfoNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x040030E2 RID: 12514
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E3 RID: 12515
		public const int ForbidListFieldNumber = 13;

		// Token: 0x040030E4 RID: 12516
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(106U, ControlParam.Parser);

		// Token: 0x040030E5 RID: 12517
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
