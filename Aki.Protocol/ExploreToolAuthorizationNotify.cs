using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F8 RID: 1272
	[NetMessage(EMessageId.ExploreToolAuthorizationNotify)]
	public sealed class ExploreToolAuthorizationNotify : IMessage<ExploreToolAuthorizationNotify>, IMessage, IEquatable<ExploreToolAuthorizationNotify>, IDeepCloneable<ExploreToolAuthorizationNotify>, IBufferMessage
	{
		// Token: 0x06007843 RID: 30787 RVA: 0x001250AC File Offset: 0x001232AC
		[NullableContext(1)]
		public static ExploreToolAuthorizationNotify Create()
		{
			return new ExploreToolAuthorizationNotify();
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x001250B3 File Offset: 0x001232B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x001250B6 File Offset: 0x001232B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolAuthorizationNotify.Descriptor;
			}
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x001250BD File Offset: 0x001232BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify()
		{
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x001250D0 File Offset: 0x001232D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify(ExploreToolAuthorizationNotify other) : this()
		{
			this.authorizationItems_ = other.authorizationItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x001250FA File Offset: 0x001232FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify Clone()
		{
			return new ExploreToolAuthorizationNotify(this);
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x00125102 File Offset: 0x00123302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AuthorizationItems
		{
			get
			{
				return this.authorizationItems_;
			}
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x0012510A File Offset: 0x0012330A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolAuthorizationNotify);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00125118 File Offset: 0x00123318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolAuthorizationNotify other)
		{
			return other != null && (other == this || (this.authorizationItems_.Equals(other.authorizationItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0012514C File Offset: 0x0012334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.authorizationItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00125180 File Offset: 0x00123380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x0012518D File Offset: 0x0012338D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00125196 File Offset: 0x00123396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.authorizationItems_.WriteTo(ref output, ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x001251C0 File Offset: 0x001233C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.authorizationItems_.CalculateSize(ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x001251F9 File Offset: 0x001233F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreToolAuthorizationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.authorizationItems_.Add(other.authorizationItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x00125227 File Offset: 0x00123427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x00125230 File Offset: 0x00123430
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.authorizationItems_.AddEntriesFrom(ref input, ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
				}
			}
		}

		// Token: 0x04003EB1 RID: 16049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EB2 RID: 16050
		public const int AuthorizationItemsFieldNumber = 5;

		// Token: 0x04003EB3 RID: 16051
		private static readonly FieldCodec<int> _repeated_authorizationItems_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04003EB4 RID: 16052
		private readonly RepeatedField<int> authorizationItems_ = new RepeatedField<int>();
	}
}
