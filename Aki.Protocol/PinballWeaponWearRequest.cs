using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6F RID: 3439
	[NetMessage(EMessageId.PinballWeaponWearRequest)]
	public sealed class PinballWeaponWearRequest : IMessage<PinballWeaponWearRequest>, IMessage, IEquatable<PinballWeaponWearRequest>, IDeepCloneable<PinballWeaponWearRequest>, IBufferMessage
	{
		// Token: 0x060128A4 RID: 75940 RVA: 0x002B44E9 File Offset: 0x002B26E9
		[NullableContext(1)]
		public static PinballWeaponWearRequest Create()
		{
			return new PinballWeaponWearRequest();
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x060128A5 RID: 75941 RVA: 0x002B44F0 File Offset: 0x002B26F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x060128A6 RID: 75942 RVA: 0x002B44F3 File Offset: 0x002B26F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponWearRequest.Descriptor;
			}
		}

		// Token: 0x060128A7 RID: 75943 RVA: 0x002B44FA File Offset: 0x002B26FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest()
		{
		}

		// Token: 0x060128A8 RID: 75944 RVA: 0x002B4502 File Offset: 0x002B2702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest(PinballWeaponWearRequest other) : this()
		{
			this.weaponInc_ = other.weaponInc_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128A9 RID: 75945 RVA: 0x002B4533 File Offset: 0x002B2733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest Clone()
		{
			return new PinballWeaponWearRequest(this);
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x060128AA RID: 75946 RVA: 0x002B453B File Offset: 0x002B273B
		// (set) Token: 0x060128AB RID: 75947 RVA: 0x002B4543 File Offset: 0x002B2743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponInc
		{
			get
			{
				return this.weaponInc_;
			}
			set
			{
				this.weaponInc_ = value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x060128AC RID: 75948 RVA: 0x002B454C File Offset: 0x002B274C
		// (set) Token: 0x060128AD RID: 75949 RVA: 0x002B4554 File Offset: 0x002B2754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x060128AE RID: 75950 RVA: 0x002B455D File Offset: 0x002B275D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponWearRequest);
		}

		// Token: 0x060128AF RID: 75951 RVA: 0x002B456B File Offset: 0x002B276B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponWearRequest other)
		{
			return other != null && (other == this || (this.WeaponInc == other.WeaponInc && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128B0 RID: 75952 RVA: 0x002B45AC File Offset: 0x002B27AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponInc != 0)
			{
				num ^= this.WeaponInc.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060128B1 RID: 75953 RVA: 0x002B4604 File Offset: 0x002B2804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128B2 RID: 75954 RVA: 0x002B4611 File Offset: 0x002B2811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128B3 RID: 75955 RVA: 0x002B461C File Offset: 0x002B281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.WeaponInc != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WeaponInc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128B4 RID: 75956 RVA: 0x002B4678 File Offset: 0x002B2878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponInc != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponInc);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060128B5 RID: 75957 RVA: 0x002B46D0 File Offset: 0x002B28D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponWearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponInc != 0)
			{
				this.WeaponInc = other.WeaponInc;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x002B4720 File Offset: 0x002B2920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128B7 RID: 75959 RVA: 0x002B472C File Offset: 0x002B292C
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
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeaponInc = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400732A RID: 29482
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400732B RID: 29483
		public const int WeaponIncFieldNumber = 15;

		// Token: 0x0400732C RID: 29484
		private int weaponInc_;

		// Token: 0x0400732D RID: 29485
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400732E RID: 29486
		private int roleId_;
	}
}
