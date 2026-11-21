using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000979 RID: 2425
	[NetMessage(EMessageId.MapMarkInfoUpdateRequest)]
	public sealed class MapMarkInfoUpdateRequest : IMessage<MapMarkInfoUpdateRequest>, IMessage, IEquatable<MapMarkInfoUpdateRequest>, IDeepCloneable<MapMarkInfoUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600D592 RID: 54674 RVA: 0x001F705D File Offset: 0x001F525D
		[NullableContext(1)]
		public static MapMarkInfoUpdateRequest Create()
		{
			return new MapMarkInfoUpdateRequest();
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600D593 RID: 54675 RVA: 0x001F7064 File Offset: 0x001F5264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600D594 RID: 54676 RVA: 0x001F7067 File Offset: 0x001F5267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x001F706E File Offset: 0x001F526E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest()
		{
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x001F7078 File Offset: 0x001F5278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest(MapMarkInfoUpdateRequest other) : this()
		{
			this.markId_ = other.markId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x001F70C4 File Offset: 0x001F52C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest Clone()
		{
			return new MapMarkInfoUpdateRequest(this);
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600D598 RID: 54680 RVA: 0x001F70CC File Offset: 0x001F52CC
		// (set) Token: 0x0600D599 RID: 54681 RVA: 0x001F70D4 File Offset: 0x001F52D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600D59A RID: 54682 RVA: 0x001F70DD File Offset: 0x001F52DD
		// (set) Token: 0x0600D59B RID: 54683 RVA: 0x001F70E5 File Offset: 0x001F52E5
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

		// Token: 0x0600D59C RID: 54684 RVA: 0x001F70EE File Offset: 0x001F52EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoUpdateRequest);
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x001F70FC File Offset: 0x001F52FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoUpdateRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D59E RID: 54686 RVA: 0x001F714C File Offset: 0x001F534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x001F71A1 File Offset: 0x001F53A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x001F71AE File Offset: 0x001F53AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x001F71B8 File Offset: 0x001F53B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x001F7210 File Offset: 0x001F5410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x001F7268 File Offset: 0x001F5468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x001F72D0 File Offset: 0x001F54D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x001F72DC File Offset: 0x001F54DC
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
				if (num != 8U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040059C2 RID: 22978
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C3 RID: 22979
		public const int MarkIdFieldNumber = 1;

		// Token: 0x040059C4 RID: 22980
		private int markId_;

		// Token: 0x040059C5 RID: 22981
		public const int PosFieldNumber = 13;

		// Token: 0x040059C6 RID: 22982
		private Vector pos_;
	}
}
