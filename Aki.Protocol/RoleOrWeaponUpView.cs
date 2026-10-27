using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001095 RID: 4245
	public sealed class RoleOrWeaponUpView : IMessage<RoleOrWeaponUpView>, IMessage, IEquatable<RoleOrWeaponUpView>, IDeepCloneable<RoleOrWeaponUpView>, IBufferMessage
	{
		// Token: 0x06016AD2 RID: 92882 RVA: 0x0034BE0F File Offset: 0x0034A00F
		[NullableContext(1)]
		public static RoleOrWeaponUpView Create()
		{
			return new RoleOrWeaponUpView();
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x06016AD3 RID: 92883 RVA: 0x0034BE16 File Offset: 0x0034A016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x06016AD4 RID: 92884 RVA: 0x0034BE19 File Offset: 0x0034A019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOrWeaponUpView.Descriptor;
			}
		}

		// Token: 0x06016AD5 RID: 92885 RVA: 0x0034BE20 File Offset: 0x0034A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView()
		{
		}

		// Token: 0x06016AD6 RID: 92886 RVA: 0x0034BE28 File Offset: 0x0034A028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView(RoleOrWeaponUpView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AD7 RID: 92887 RVA: 0x0034BE5D File Offset: 0x0034A05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView Clone()
		{
			return new RoleOrWeaponUpView(this);
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06016AD8 RID: 92888 RVA: 0x0034BE65 File Offset: 0x0034A065
		// (set) Token: 0x06016AD9 RID: 92889 RVA: 0x0034BE6D File Offset: 0x0034A06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption SurvivorsOption
		{
			get
			{
				return this.survivorsOption_;
			}
			set
			{
				this.survivorsOption_ = value;
			}
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x0034BE76 File Offset: 0x0034A076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOrWeaponUpView);
		}

		// Token: 0x06016ADB RID: 92891 RVA: 0x0034BE84 File Offset: 0x0034A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOrWeaponUpView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016ADC RID: 92892 RVA: 0x0034BEB8 File Offset: 0x0034A0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorsOption_ != null)
			{
				num ^= this.SurvivorsOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016ADD RID: 92893 RVA: 0x0034BEF4 File Offset: 0x0034A0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x0034BF01 File Offset: 0x0034A101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ADF RID: 92895 RVA: 0x0034BF0A File Offset: 0x0034A10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorsOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016AE0 RID: 92896 RVA: 0x0034BF3C File Offset: 0x0034A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorsOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016AE1 RID: 92897 RVA: 0x0034BF7C File Offset: 0x0034A17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleOrWeaponUpView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorsOption_ != null)
			{
				if (this.survivorsOption_ == null)
				{
					this.SurvivorsOption = new SurvivorsOption();
				}
				this.SurvivorsOption.MergeFrom(other.SurvivorsOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016AE2 RID: 92898 RVA: 0x0034BFD0 File Offset: 0x0034A1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AE3 RID: 92899 RVA: 0x0034BFDC File Offset: 0x0034A1DC
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
					if (this.survivorsOption_ == null)
					{
						this.SurvivorsOption = new SurvivorsOption();
					}
					input.ReadMessage(this.SurvivorsOption);
				}
			}
		}

		// Token: 0x04008780 RID: 34688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008781 RID: 34689
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x04008782 RID: 34690
		private SurvivorsOption survivorsOption_;
	}
}
