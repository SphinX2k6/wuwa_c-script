using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E3 RID: 2531
	[NetMessage(EMessageId.MobileButtonSettingUpdateRequest)]
	public sealed class MobileButtonSettingUpdateRequest : IMessage<MobileButtonSettingUpdateRequest>, IMessage, IEquatable<MobileButtonSettingUpdateRequest>, IDeepCloneable<MobileButtonSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600DDCD RID: 56781 RVA: 0x00208992 File Offset: 0x00206B92
		[NullableContext(1)]
		public static MobileButtonSettingUpdateRequest Create()
		{
			return new MobileButtonSettingUpdateRequest();
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x00208999 File Offset: 0x00206B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600DDCF RID: 56783 RVA: 0x0020899C File Offset: 0x00206B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x002089A3 File Offset: 0x00206BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest()
		{
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x002089B6 File Offset: 0x00206BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest(MobileButtonSettingUpdateRequest other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x002089E0 File Offset: 0x00206BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest Clone()
		{
			return new MobileButtonSettingUpdateRequest(this);
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x002089E8 File Offset: 0x00206BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x002089F0 File Offset: 0x00206BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSettingUpdateRequest);
		}

		// Token: 0x0600DDD5 RID: 56789 RVA: 0x002089FE File Offset: 0x00206BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x00208A34 File Offset: 0x00206C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mobileButtonSettings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x00208A68 File Offset: 0x00206C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00208A75 File Offset: 0x00206C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x00208A7E File Offset: 0x00206C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mobileButtonSettings_.WriteTo(ref output, MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x00208AA8 File Offset: 0x00206CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mobileButtonSettings_.CalculateSize(MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DDDB RID: 56795 RVA: 0x00208AE1 File Offset: 0x00206CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MobileButtonSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mobileButtonSettings_.Add(other.mobileButtonSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DDDC RID: 56796 RVA: 0x00208B0F File Offset: 0x00206D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDDD RID: 56797 RVA: 0x00208B18 File Offset: 0x00206D18
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
					this.mobileButtonSettings_.AddEntriesFrom(ref input, MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
				}
			}
		}

		// Token: 0x04005BAE RID: 23470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BAF RID: 23471
		public const int MobileButtonSettingsFieldNumber = 6;

		// Token: 0x04005BB0 RID: 23472
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(50U, MobileButtonSetting.Parser);

		// Token: 0x04005BB1 RID: 23473
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
