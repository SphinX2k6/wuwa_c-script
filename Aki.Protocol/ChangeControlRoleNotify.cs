using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000247 RID: 583
	[NetMessage(EMessageId.ChangeControlRoleNotify)]
	public sealed class ChangeControlRoleNotify : IMessage<ChangeControlRoleNotify>, IMessage, IEquatable<ChangeControlRoleNotify>, IDeepCloneable<ChangeControlRoleNotify>, IBufferMessage
	{
		// Token: 0x06003E69 RID: 15977 RVA: 0x00099F8C File Offset: 0x0009818C
		[NullableContext(1)]
		public static ChangeControlRoleNotify Create()
		{
			return new ChangeControlRoleNotify();
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003E6A RID: 15978 RVA: 0x00099F93 File Offset: 0x00098193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x00099F96 File Offset: 0x00098196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeControlRoleNotify.Descriptor;
			}
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00099F9D File Offset: 0x0009819D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeControlRoleNotify()
		{
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00099FA8 File Offset: 0x000981A8
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

		// Token: 0x06003E6E RID: 15982 RVA: 0x0009A018 File Offset: 0x00098218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeControlRoleNotify Clone()
		{
			return new ChangeControlRoleNotify(this);
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x0009A020 File Offset: 0x00098220
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x0009A028 File Offset: 0x00098228
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x0009A031 File Offset: 0x00098231
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x0009A039 File Offset: 0x00098239
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

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x0009A042 File Offset: 0x00098242
		// (set) Token: 0x06003E74 RID: 15988 RVA: 0x0009A04A File Offset: 0x0009824A
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

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x0009A053 File Offset: 0x00098253
		// (set) Token: 0x06003E76 RID: 15990 RVA: 0x0009A05B File Offset: 0x0009825B
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x0009A064 File Offset: 0x00098264
		// (set) Token: 0x06003E78 RID: 15992 RVA: 0x0009A06C File Offset: 0x0009826C
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

		// Token: 0x06003E79 RID: 15993 RVA: 0x0009A075 File Offset: 0x00098275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeControlRoleNotify);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0009A084 File Offset: 0x00098284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeControlRoleNotify other)
		{
			return other != null && (other == this || (this.UpId == other.UpId && this.DownId == other.DownId && this.PlayerId == other.PlayerId && this.NeedSetLocation == other.NeedSetLocation && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0009A104 File Offset: 0x00098304
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

		// Token: 0x06003E7C RID: 15996 RVA: 0x0009A1A4 File Offset: 0x000983A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x0009A1B1 File Offset: 0x000983B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0009A1BC File Offset: 0x000983BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DownId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.DownId);
			}
			if (this.NeedSetLocation)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NeedSetLocation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Location);
			}
			if (this.UpId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.UpId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0009A26C File Offset: 0x0009846C
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

		// Token: 0x06003E80 RID: 16000 RVA: 0x0009A300 File Offset: 0x00098500
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

		// Token: 0x06003E81 RID: 16001 RVA: 0x0009A3A4 File Offset: 0x000985A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x0009A3B0 File Offset: 0x000985B0
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.DownId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.NeedSetLocation = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 72U)
					{
						this.UpId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CDD RID: 11485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CDE RID: 11486
		public const int UpIdFieldNumber = 9;

		// Token: 0x04002CDF RID: 11487
		private long upId_;

		// Token: 0x04002CE0 RID: 11488
		public const int DownIdFieldNumber = 2;

		// Token: 0x04002CE1 RID: 11489
		private long downId_;

		// Token: 0x04002CE2 RID: 11490
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002CE3 RID: 11491
		private int playerId_;

		// Token: 0x04002CE4 RID: 11492
		public const int NeedSetLocationFieldNumber = 5;

		// Token: 0x04002CE5 RID: 11493
		private bool needSetLocation_;

		// Token: 0x04002CE6 RID: 11494
		public const int LocationFieldNumber = 7;

		// Token: 0x04002CE7 RID: 11495
		private Vector location_;
	}
}
