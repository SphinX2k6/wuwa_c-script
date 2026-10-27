using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F6 RID: 5110
	public sealed class Transform : IMessage<Transform>, IMessage, IEquatable<Transform>, IDeepCloneable<Transform>, IBufferMessage
	{
		// Token: 0x0601B137 RID: 110903 RVA: 0x003EB9CC File Offset: 0x003E9BCC
		[NullableContext(1)]
		public static Transform Create()
		{
			return new Transform();
		}

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x0601B138 RID: 110904 RVA: 0x003EB9D3 File Offset: 0x003E9BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x0601B139 RID: 110905 RVA: 0x003EB9D6 File Offset: 0x003E9BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Transform.Descriptor;
			}
		}

		// Token: 0x0601B13A RID: 110906 RVA: 0x003EB9DD File Offset: 0x003E9BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform()
		{
		}

		// Token: 0x0601B13B RID: 110907 RVA: 0x003EB9E8 File Offset: 0x003E9BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform(Transform other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B13C RID: 110908 RVA: 0x003EBA44 File Offset: 0x003E9C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Clone()
		{
			return new Transform(this);
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0601B13D RID: 110909 RVA: 0x003EBA4C File Offset: 0x003E9C4C
		// (set) Token: 0x0601B13E RID: 110910 RVA: 0x003EBA54 File Offset: 0x003E9C54
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

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x0601B13F RID: 110911 RVA: 0x003EBA5D File Offset: 0x003E9C5D
		// (set) Token: 0x0601B140 RID: 110912 RVA: 0x003EBA65 File Offset: 0x003E9C65
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

		// Token: 0x0601B141 RID: 110913 RVA: 0x003EBA6E File Offset: 0x003E9C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Transform);
		}

		// Token: 0x0601B142 RID: 110914 RVA: 0x003EBA7C File Offset: 0x003E9C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Transform other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B143 RID: 110915 RVA: 0x003EBAD0 File Offset: 0x003E9CD0
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

		// Token: 0x0601B144 RID: 110916 RVA: 0x003EBB22 File Offset: 0x003E9D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B145 RID: 110917 RVA: 0x003EBB2F File Offset: 0x003E9D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B146 RID: 110918 RVA: 0x003EBB38 File Offset: 0x003E9D38
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

		// Token: 0x0601B147 RID: 110919 RVA: 0x003EBB94 File Offset: 0x003E9D94
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

		// Token: 0x0601B148 RID: 110920 RVA: 0x003EBBEC File Offset: 0x003E9DEC
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

		// Token: 0x0601B149 RID: 110921 RVA: 0x003EBC6C File Offset: 0x003E9E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B14A RID: 110922 RVA: 0x003EBC78 File Offset: 0x003E9E78
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

		// Token: 0x04009C9F RID: 40095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CA0 RID: 40096
		public const int PosFieldNumber = 1;

		// Token: 0x04009CA1 RID: 40097
		private Vector pos_;

		// Token: 0x04009CA2 RID: 40098
		public const int RotFieldNumber = 2;

		// Token: 0x04009CA3 RID: 40099
		private Rotator rot_;
	}
}
