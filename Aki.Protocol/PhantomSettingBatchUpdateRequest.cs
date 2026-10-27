using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFF RID: 3327
	[NetMessage(EMessageId.PhantomSettingBatchUpdateRequest)]
	public sealed class PhantomSettingBatchUpdateRequest : IMessage<PhantomSettingBatchUpdateRequest>, IMessage, IEquatable<PhantomSettingBatchUpdateRequest>, IDeepCloneable<PhantomSettingBatchUpdateRequest>, IBufferMessage
	{
		// Token: 0x06011FC4 RID: 73668 RVA: 0x002A1352 File Offset: 0x0029F552
		[NullableContext(1)]
		public static PhantomSettingBatchUpdateRequest Create()
		{
			return new PhantomSettingBatchUpdateRequest();
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x06011FC5 RID: 73669 RVA: 0x002A1359 File Offset: 0x0029F559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x06011FC6 RID: 73670 RVA: 0x002A135C File Offset: 0x0029F55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingBatchUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06011FC7 RID: 73671 RVA: 0x002A1363 File Offset: 0x0029F563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest()
		{
		}

		// Token: 0x06011FC8 RID: 73672 RVA: 0x002A1376 File Offset: 0x0029F576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest(PhantomSettingBatchUpdateRequest other) : this()
		{
			this.settings_ = other.settings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FC9 RID: 73673 RVA: 0x002A13A0 File Offset: 0x0029F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateRequest Clone()
		{
			return new PhantomSettingBatchUpdateRequest(this);
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x06011FCA RID: 73674 RVA: 0x002A13A8 File Offset: 0x0029F5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomSettingInfo> Settings
		{
			get
			{
				return this.settings_;
			}
		}

		// Token: 0x06011FCB RID: 73675 RVA: 0x002A13B0 File Offset: 0x0029F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingBatchUpdateRequest);
		}

		// Token: 0x06011FCC RID: 73676 RVA: 0x002A13BE File Offset: 0x0029F5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingBatchUpdateRequest other)
		{
			return other != null && (other == this || (this.settings_.Equals(other.settings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FCD RID: 73677 RVA: 0x002A13F4 File Offset: 0x0029F5F4
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

		// Token: 0x06011FCE RID: 73678 RVA: 0x002A1428 File Offset: 0x0029F628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FCF RID: 73679 RVA: 0x002A1435 File Offset: 0x0029F635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FD0 RID: 73680 RVA: 0x002A143E File Offset: 0x0029F63E
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

		// Token: 0x06011FD1 RID: 73681 RVA: 0x002A1468 File Offset: 0x0029F668
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

		// Token: 0x06011FD2 RID: 73682 RVA: 0x002A14A1 File Offset: 0x0029F6A1
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

		// Token: 0x06011FD3 RID: 73683 RVA: 0x002A14CF File Offset: 0x0029F6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FD4 RID: 73684 RVA: 0x002A14D8 File Offset: 0x0029F6D8
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.settings_.AddEntriesFrom(ref input, PhantomSettingBatchUpdateRequest._repeated_settings_codec);
				}
			}
		}

		// Token: 0x040070B6 RID: 28854
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070B7 RID: 28855
		public const int SettingsFieldNumber = 15;

		// Token: 0x040070B8 RID: 28856
		private static readonly FieldCodec<PhantomSettingInfo> _repeated_settings_codec = FieldCodec.ForMessage<PhantomSettingInfo>(122U, PhantomSettingInfo.Parser);

		// Token: 0x040070B9 RID: 28857
		private readonly RepeatedField<PhantomSettingInfo> settings_ = new RepeatedField<PhantomSettingInfo>();
	}
}
