using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B2 RID: 178
	[NetMessage(EMessageId.AddTemporaryTeleportRequest)]
	public sealed class AddTemporaryTeleportRequest : IMessage<AddTemporaryTeleportRequest>, IMessage, IEquatable<AddTemporaryTeleportRequest>, IDeepCloneable<AddTemporaryTeleportRequest>, IBufferMessage
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x00051FC0 File Offset: 0x000501C0
		[NullableContext(1)]
		public static AddTemporaryTeleportRequest Create()
		{
			return new AddTemporaryTeleportRequest();
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00051FC7 File Offset: 0x000501C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00051FCA File Offset: 0x000501CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00051FD1 File Offset: 0x000501D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest()
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00051FDC File Offset: 0x000501DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest(AddTemporaryTeleportRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.area_ = other.area_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00052044 File Offset: 0x00050244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest Clone()
		{
			return new AddTemporaryTeleportRequest(this);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0005204C File Offset: 0x0005024C
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00052054 File Offset: 0x00050254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0005205D File Offset: 0x0005025D
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00052065 File Offset: 0x00050265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0005206E File Offset: 0x0005026E
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00052076 File Offset: 0x00050276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Area
		{
			get
			{
				return this.area_;
			}
			set
			{
				this.area_ = value;
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0005207F File Offset: 0x0005027F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportRequest);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00052090 File Offset: 0x00050290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.Area == other.Area && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x000520F4 File Offset: 0x000502F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.Area != 0)
			{
				num ^= this.Area.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0005215F File Offset: 0x0005035F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0005216C File Offset: 0x0005036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00052178 File Offset: 0x00050378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rot);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Pos);
			}
			if (this.Area != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Area);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000521F0 File Offset: 0x000503F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.Area != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Area);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00052260 File Offset: 0x00050460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTemporaryTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.Area != 0)
			{
				this.Area = other.Area;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000522F4 File Offset: 0x000504F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00052300 File Offset: 0x00050500
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
				if (num != 34U)
				{
					if (num != 90U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Area = input.ReadInt32();
						}
					}
					else
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
					}
				}
				else
				{
					if (this.rot_ == null)
					{
						this.Rot = new Rotator();
					}
					input.ReadMessage(this.Rot);
				}
			}
		}

		// Token: 0x04002385 RID: 9093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002386 RID: 9094
		public const int PosFieldNumber = 11;

		// Token: 0x04002387 RID: 9095
		private Vector pos_;

		// Token: 0x04002388 RID: 9096
		public const int RotFieldNumber = 4;

		// Token: 0x04002389 RID: 9097
		private Rotator rot_;

		// Token: 0x0400238A RID: 9098
		public const int AreaFieldNumber = 12;

		// Token: 0x0400238B RID: 9099
		private int area_;
	}
}
