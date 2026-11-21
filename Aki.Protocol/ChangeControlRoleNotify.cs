using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024C RID: 588
	[NetMessage(EMessageId.ChangeControlRoleNotify)]
	public sealed class ChangeControlRoleNotify : IMessage<ChangeControlRoleNotify>, IMessage, IEquatable<ChangeControlRoleNotify>, IDeepCloneable<ChangeControlRoleNotify>, IBufferMessage
	{
		// Token: 0x06003F0E RID: 16142 RVA: 0x0009BBAD File Offset: 0x00099DAD
		[NullableContext(1)]
		public static ChangeControlRoleNotify Create()
		{
			return new ChangeControlRoleNotify();
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0009BBB4 File Offset: 0x00099DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0009BBB7 File Offset: 0x00099DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeControlRoleNotify.Descriptor;
			}
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0009BBBE File Offset: 0x00099DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeControlRoleNotify()
		{
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0009BBC8 File Offset: 0x00099DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeControlRoleNotify(ChangeControlRoleNotify other) : this()
		{
			this.upId_ = other.upId_;
			this.downId_ = other.downId_;
			this.playerId_ = other.playerId_;
			this.needSetLocation_ = other.needSetLocation_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0009BC38 File Offset: 0x00099E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeControlRoleNotify Clone()
		{
			return new ChangeControlRoleNotify(this);
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x0009BC40 File Offset: 0x00099E40
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x0009BC48 File Offset: 0x00099E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpId
		{
			get
			{
				return this.upId_;
			}
			set
			{
				this.upId_ = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x0009BC51 File Offset: 0x00099E51
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x0009BC59 File Offset: 0x00099E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DownId
		{
			get
			{
				return this.downId_;
			}
			set
			{
				this.downId_ = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x0009BC62 File Offset: 0x00099E62
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x0009BC6A File Offset: 0x00099E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x0009BC73 File Offset: 0x00099E73
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x0009BC7B File Offset: 0x00099E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedSetLocation
		{
			get
			{
				return this.needSetLocation_;
			}
			set
			{
				this.needSetLocation_ = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x0009BC84 File Offset: 0x00099E84
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x0009BC8C File Offset: 0x00099E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x0009BC95 File Offset: 0x00099E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeControlRoleNotify);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeControlRoleNotify other)
		{
			return other != null && (other == this || (this.UpId == other.UpId && this.DownId == other.DownId && this.PlayerId == other.PlayerId && this.NeedSetLocation == other.NeedSetLocation && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0009BD24 File Offset: 0x00099F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UpId != 0L)
			{
				num ^= this.UpId.GetHashCode();
			}
			if (this.DownId != 0L)
			{
				num ^= this.DownId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.NeedSetLocation)
			{
				num ^= this.NeedSetLocation.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0009BDC4 File Offset: 0x00099FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0009BDD1 File Offset: 0x00099FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0009BDDC File Offset: 0x00099FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			if (this.NeedSetLocation)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NeedSetLocation);
			}
			if (this.DownId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.DownId);
			}
			if (this.UpId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.UpId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0009BE8C File Offset: 0x0009A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UpId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpId);
			}
			if (this.DownId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DownId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.NeedSetLocation)
			{
				num += 2;
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0009BF20 File Offset: 0x0009A120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeControlRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UpId != 0L)
			{
				this.UpId = other.UpId;
			}
			if (other.DownId != 0L)
			{
				this.DownId = other.DownId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.NeedSetLocation)
			{
				this.NeedSetLocation = other.NeedSetLocation;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0009BFC4 File Offset: 0x0009A1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0009BFD0 File Offset: 0x0009A1D0
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
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.NeedSetLocation = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.DownId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.UpId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D5F RID: 11615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D60 RID: 11616
		public const int UpIdFieldNumber = 13;

		// Token: 0x04002D61 RID: 11617
		private long upId_;

		// Token: 0x04002D62 RID: 11618
		public const int DownIdFieldNumber = 9;

		// Token: 0x04002D63 RID: 11619
		private long downId_;

		// Token: 0x04002D64 RID: 11620
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04002D65 RID: 11621
		private int playerId_;

		// Token: 0x04002D66 RID: 11622
		public const int NeedSetLocationFieldNumber = 5;

		// Token: 0x04002D67 RID: 11623
		private bool needSetLocation_;

		// Token: 0x04002D68 RID: 11624
		public const int LocationFieldNumber = 4;

		// Token: 0x04002D69 RID: 11625
		private Vector location_;
	}
}
