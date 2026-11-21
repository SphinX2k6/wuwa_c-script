using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBA RID: 3514
	public sealed class PositionAndRotate : IMessage<PositionAndRotate>, IMessage, IEquatable<PositionAndRotate>, IDeepCloneable<PositionAndRotate>, IBufferMessage
	{
		// Token: 0x06012F19 RID: 77593 RVA: 0x002C3700 File Offset: 0x002C1900
		[NullableContext(1)]
		public static PositionAndRotate Create()
		{
			return new PositionAndRotate();
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x06012F1A RID: 77594 RVA: 0x002C3707 File Offset: 0x002C1907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x06012F1B RID: 77595 RVA: 0x002C370A File Offset: 0x002C190A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PositionAndRotate.Descriptor;
			}
		}

		// Token: 0x06012F1C RID: 77596 RVA: 0x002C3711 File Offset: 0x002C1911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate()
		{
		}

		// Token: 0x06012F1D RID: 77597 RVA: 0x002C371C File Offset: 0x002C191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate(PositionAndRotate other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F1E RID: 77598 RVA: 0x002C3778 File Offset: 0x002C1978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PositionAndRotate Clone()
		{
			return new PositionAndRotate(this);
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x06012F1F RID: 77599 RVA: 0x002C3780 File Offset: 0x002C1980
		// (set) Token: 0x06012F20 RID: 77600 RVA: 0x002C3788 File Offset: 0x002C1988
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

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06012F21 RID: 77601 RVA: 0x002C3791 File Offset: 0x002C1991
		// (set) Token: 0x06012F22 RID: 77602 RVA: 0x002C3799 File Offset: 0x002C1999
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

		// Token: 0x06012F23 RID: 77603 RVA: 0x002C37A2 File Offset: 0x002C19A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PositionAndRotate);
		}

		// Token: 0x06012F24 RID: 77604 RVA: 0x002C37B0 File Offset: 0x002C19B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PositionAndRotate other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F25 RID: 77605 RVA: 0x002C3804 File Offset: 0x002C1A04
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

		// Token: 0x06012F26 RID: 77606 RVA: 0x002C3856 File Offset: 0x002C1A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F27 RID: 77607 RVA: 0x002C3863 File Offset: 0x002C1A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F28 RID: 77608 RVA: 0x002C386C File Offset: 0x002C1A6C
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

		// Token: 0x06012F29 RID: 77609 RVA: 0x002C38C8 File Offset: 0x002C1AC8
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

		// Token: 0x06012F2A RID: 77610 RVA: 0x002C3920 File Offset: 0x002C1B20
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

		// Token: 0x06012F2B RID: 77611 RVA: 0x002C39A0 File Offset: 0x002C1BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F2C RID: 77612 RVA: 0x002C39AC File Offset: 0x002C1BAC
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

		// Token: 0x0400757A RID: 30074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400757B RID: 30075
		public const int PosFieldNumber = 1;

		// Token: 0x0400757C RID: 30076
		private Vector pos_;

		// Token: 0x0400757D RID: 30077
		public const int RotFieldNumber = 2;

		// Token: 0x0400757E RID: 30078
		private Rotator rot_;
	}
}
