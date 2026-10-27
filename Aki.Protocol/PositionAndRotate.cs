using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCB RID: 3531
	public sealed class PositionAndRotate : IMessage<PositionAndRotate>, IMessage, IEquatable<PositionAndRotate>, IDeepCloneable<PositionAndRotate>, IBufferMessage
	{
		// Token: 0x06013029 RID: 77865 RVA: 0x002C55B0 File Offset: 0x002C37B0
		[NullableContext(1)]
		public static PositionAndRotate Create()
		{
			return new PositionAndRotate();
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0601302A RID: 77866 RVA: 0x002C55B7 File Offset: 0x002C37B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0601302B RID: 77867 RVA: 0x002C55BA File Offset: 0x002C37BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PositionAndRotate.Descriptor;
			}
		}

		// Token: 0x0601302C RID: 77868 RVA: 0x002C55C1 File Offset: 0x002C37C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate()
		{
		}

		// Token: 0x0601302D RID: 77869 RVA: 0x002C55CC File Offset: 0x002C37CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate(PositionAndRotate other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601302E RID: 77870 RVA: 0x002C5628 File Offset: 0x002C3828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate Clone()
		{
			return new PositionAndRotate(this);
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0601302F RID: 77871 RVA: 0x002C5630 File Offset: 0x002C3830
		// (set) Token: 0x06013030 RID: 77872 RVA: 0x002C5638 File Offset: 0x002C3838
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

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x06013031 RID: 77873 RVA: 0x002C5641 File Offset: 0x002C3841
		// (set) Token: 0x06013032 RID: 77874 RVA: 0x002C5649 File Offset: 0x002C3849
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

		// Token: 0x06013033 RID: 77875 RVA: 0x002C5652 File Offset: 0x002C3852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PositionAndRotate);
		}

		// Token: 0x06013034 RID: 77876 RVA: 0x002C5660 File Offset: 0x002C3860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PositionAndRotate other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013035 RID: 77877 RVA: 0x002C56B4 File Offset: 0x002C38B4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013036 RID: 77878 RVA: 0x002C5706 File Offset: 0x002C3906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013037 RID: 77879 RVA: 0x002C5713 File Offset: 0x002C3913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013038 RID: 77880 RVA: 0x002C571C File Offset: 0x002C391C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013039 RID: 77881 RVA: 0x002C5778 File Offset: 0x002C3978
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601303A RID: 77882 RVA: 0x002C57D0 File Offset: 0x002C39D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PositionAndRotate other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601303B RID: 77883 RVA: 0x002C5850 File Offset: 0x002C3A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601303C RID: 77884 RVA: 0x002C585C File Offset: 0x002C3A5C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04007567 RID: 30055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007568 RID: 30056
		public const int PosFieldNumber = 1;

		// Token: 0x04007569 RID: 30057
		private Vector pos_;

		// Token: 0x0400756A RID: 30058
		public const int RotFieldNumber = 2;

		// Token: 0x0400756B RID: 30059
		private Rotator rot_;
	}
}
