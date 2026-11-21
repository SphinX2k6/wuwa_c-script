using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001085 RID: 4229
	public sealed class RoleOrWeaponUpView : IMessage<RoleOrWeaponUpView>, IMessage, IEquatable<RoleOrWeaponUpView>, IDeepCloneable<RoleOrWeaponUpView>, IBufferMessage
	{
		// Token: 0x060169ED RID: 92653 RVA: 0x0034A733 File Offset: 0x00348933
		[NullableContext(1)]
		public static RoleOrWeaponUpView Create()
		{
			return new RoleOrWeaponUpView();
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x060169EE RID: 92654 RVA: 0x0034A73A File Offset: 0x0034893A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x060169EF RID: 92655 RVA: 0x0034A73D File Offset: 0x0034893D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOrWeaponUpView.Descriptor;
			}
		}

		// Token: 0x060169F0 RID: 92656 RVA: 0x0034A744 File Offset: 0x00348944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView()
		{
		}

		// Token: 0x060169F1 RID: 92657 RVA: 0x0034A74C File Offset: 0x0034894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView(RoleOrWeaponUpView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169F2 RID: 92658 RVA: 0x0034A781 File Offset: 0x00348981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView Clone()
		{
			return new RoleOrWeaponUpView(this);
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x060169F3 RID: 92659 RVA: 0x0034A789 File Offset: 0x00348989
		// (set) Token: 0x060169F4 RID: 92660 RVA: 0x0034A791 File Offset: 0x00348991
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

		// Token: 0x060169F5 RID: 92661 RVA: 0x0034A79A File Offset: 0x0034899A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOrWeaponUpView);
		}

		// Token: 0x060169F6 RID: 92662 RVA: 0x0034A7A8 File Offset: 0x003489A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOrWeaponUpView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169F7 RID: 92663 RVA: 0x0034A7DC File Offset: 0x003489DC
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

		// Token: 0x060169F8 RID: 92664 RVA: 0x0034A818 File Offset: 0x00348A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169F9 RID: 92665 RVA: 0x0034A825 File Offset: 0x00348A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169FA RID: 92666 RVA: 0x0034A82E File Offset: 0x00348A2E
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

		// Token: 0x060169FB RID: 92667 RVA: 0x0034A860 File Offset: 0x00348A60
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

		// Token: 0x060169FC RID: 92668 RVA: 0x0034A8A0 File Offset: 0x00348AA0
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

		// Token: 0x060169FD RID: 92669 RVA: 0x0034A8F4 File Offset: 0x00348AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169FE RID: 92670 RVA: 0x0034A900 File Offset: 0x00348B00
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

		// Token: 0x040087AA RID: 34730
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087AB RID: 34731
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x040087AC RID: 34732
		private SurvivorsOption survivorsOption_;
	}
}
