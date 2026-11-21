using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001469 RID: 5225
	public sealed class Transform : IMessage<Transform>, IMessage, IEquatable<Transform>, IDeepCloneable<Transform>, IBufferMessage
	{
		// Token: 0x0601BBC2 RID: 113602 RVA: 0x00406CA0 File Offset: 0x00404EA0
		[NullableContext(1)]
		public static Transform Create()
		{
			return new Transform();
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x0601BBC3 RID: 113603 RVA: 0x00406CA7 File Offset: 0x00404EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x0601BBC4 RID: 113604 RVA: 0x00406CAA File Offset: 0x00404EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Transform.Descriptor;
			}
		}

		// Token: 0x0601BBC5 RID: 113605 RVA: 0x00406CB1 File Offset: 0x00404EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform()
		{
		}

		// Token: 0x0601BBC6 RID: 113606 RVA: 0x00406CBC File Offset: 0x00404EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform(Transform other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBC7 RID: 113607 RVA: 0x00406D18 File Offset: 0x00404F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Clone()
		{
			return new Transform(this);
		}

		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x0601BBC8 RID: 113608 RVA: 0x00406D20 File Offset: 0x00404F20
		// (set) Token: 0x0601BBC9 RID: 113609 RVA: 0x00406D28 File Offset: 0x00404F28
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

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x0601BBCA RID: 113610 RVA: 0x00406D31 File Offset: 0x00404F31
		// (set) Token: 0x0601BBCB RID: 113611 RVA: 0x00406D39 File Offset: 0x00404F39
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

		// Token: 0x0601BBCC RID: 113612 RVA: 0x00406D42 File Offset: 0x00404F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Transform);
		}

		// Token: 0x0601BBCD RID: 113613 RVA: 0x00406D50 File Offset: 0x00404F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Transform other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBCE RID: 113614 RVA: 0x00406DA4 File Offset: 0x00404FA4
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

		// Token: 0x0601BBCF RID: 113615 RVA: 0x00406DF6 File Offset: 0x00404FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBD0 RID: 113616 RVA: 0x00406E03 File Offset: 0x00405003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBD1 RID: 113617 RVA: 0x00406E0C File Offset: 0x0040500C
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

		// Token: 0x0601BBD2 RID: 113618 RVA: 0x00406E68 File Offset: 0x00405068
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

		// Token: 0x0601BBD3 RID: 113619 RVA: 0x00406EC0 File Offset: 0x004050C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Transform other)
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

		// Token: 0x0601BBD4 RID: 113620 RVA: 0x00406F40 File Offset: 0x00405140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBD5 RID: 113621 RVA: 0x00406F4C File Offset: 0x0040514C
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

		// Token: 0x0400A0E6 RID: 41190
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0E7 RID: 41191
		public const int PosFieldNumber = 1;

		// Token: 0x0400A0E8 RID: 41192
		private Vector pos_;

		// Token: 0x0400A0E9 RID: 41193
		public const int RotFieldNumber = 2;

		// Token: 0x0400A0EA RID: 41194
		private Rotator rot_;
	}
}
