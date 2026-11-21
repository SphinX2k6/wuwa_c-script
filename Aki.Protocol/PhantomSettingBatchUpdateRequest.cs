using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEF RID: 3311
	[NetMessage(EMessageId.PhantomSettingBatchUpdateRequest)]
	public sealed class PhantomSettingBatchUpdateRequest : IMessage<PhantomSettingBatchUpdateRequest>, IMessage, IEquatable<PhantomSettingBatchUpdateRequest>, IDeepCloneable<PhantomSettingBatchUpdateRequest>, IBufferMessage
	{
		// Token: 0x06011EC8 RID: 73416 RVA: 0x0029F73A File Offset: 0x0029D93A
		[NullableContext(1)]
		public static PhantomSettingBatchUpdateRequest Create()
		{
			return new PhantomSettingBatchUpdateRequest();
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x06011EC9 RID: 73417 RVA: 0x0029F741 File Offset: 0x0029D941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x06011ECA RID: 73418 RVA: 0x0029F744 File Offset: 0x0029D944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingBatchUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06011ECB RID: 73419 RVA: 0x0029F74B File Offset: 0x0029D94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest()
		{
		}

		// Token: 0x06011ECC RID: 73420 RVA: 0x0029F75E File Offset: 0x0029D95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest(PhantomSettingBatchUpdateRequest other) : this()
		{
			this.settings_ = other.settings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011ECD RID: 73421 RVA: 0x0029F788 File Offset: 0x0029D988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest Clone()
		{
			return new PhantomSettingBatchUpdateRequest(this);
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x06011ECE RID: 73422 RVA: 0x0029F790 File Offset: 0x0029D990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomSettingInfo> Settings
		{
			get
			{
				return this.settings_;
			}
		}

		// Token: 0x06011ECF RID: 73423 RVA: 0x0029F798 File Offset: 0x0029D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingBatchUpdateRequest);
		}

		// Token: 0x06011ED0 RID: 73424 RVA: 0x0029F7A6 File Offset: 0x0029D9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingBatchUpdateRequest other)
		{
			return other != null && (other == this || (this.settings_.Equals(other.settings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011ED1 RID: 73425 RVA: 0x0029F7DC File Offset: 0x0029D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.settings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011ED2 RID: 73426 RVA: 0x0029F810 File Offset: 0x0029DA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011ED3 RID: 73427 RVA: 0x0029F81D File Offset: 0x0029DA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011ED4 RID: 73428 RVA: 0x0029F826 File Offset: 0x0029DA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.settings_.WriteTo(ref output, PhantomSettingBatchUpdateRequest._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011ED5 RID: 73429 RVA: 0x0029F850 File Offset: 0x0029DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.settings_.CalculateSize(PhantomSettingBatchUpdateRequest._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011ED6 RID: 73430 RVA: 0x0029F889 File Offset: 0x0029DA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingBatchUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.settings_.Add(other.settings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011ED7 RID: 73431 RVA: 0x0029F8B7 File Offset: 0x0029DAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011ED8 RID: 73432 RVA: 0x0029F8C0 File Offset: 0x0029DAC0
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
					this.settings_.AddEntriesFrom(ref input, PhantomSettingBatchUpdateRequest._repeated_settings_codec);
				}
			}
		}

		// Token: 0x040070CE RID: 28878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070CF RID: 28879
		public const int SettingsFieldNumber = 1;

		// Token: 0x040070D0 RID: 28880
		private static readonly FieldCodec<PhantomSettingInfo> _repeated_settings_codec = FieldCodec.ForMessage<PhantomSettingInfo>(10U, PhantomSettingInfo.Parser);

		// Token: 0x040070D1 RID: 28881
		private readonly RepeatedField<PhantomSettingInfo> settings_ = new RepeatedField<PhantomSettingInfo>();
	}
}
