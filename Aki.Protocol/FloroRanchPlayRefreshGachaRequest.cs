using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AF RID: 1455
	[NetMessage(EMessageId.FloroRanchPlayRefreshGachaRequest)]
	public sealed class FloroRanchPlayRefreshGachaRequest : IMessage<FloroRanchPlayRefreshGachaRequest>, IMessage, IEquatable<FloroRanchPlayRefreshGachaRequest>, IDeepCloneable<FloroRanchPlayRefreshGachaRequest>, IBufferMessage
	{
		// Token: 0x06008702 RID: 34562 RVA: 0x00145E58 File Offset: 0x00144058
		[NullableContext(1)]
		public static FloroRanchPlayRefreshGachaRequest Create()
		{
			return new FloroRanchPlayRefreshGachaRequest();
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008703 RID: 34563 RVA: 0x00145E5F File Offset: 0x0014405F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x00145E62 File Offset: 0x00144062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshGachaRequest.Descriptor;
			}
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x00145E69 File Offset: 0x00144069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest()
		{
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x00145E71 File Offset: 0x00144071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest(FloroRanchPlayRefreshGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x00145EAE File Offset: 0x001440AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest Clone()
		{
			return new FloroRanchPlayRefreshGachaRequest(this);
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008708 RID: 34568 RVA: 0x00145EB6 File Offset: 0x001440B6
		// (set) Token: 0x06008709 RID: 34569 RVA: 0x00145EBE File Offset: 0x001440BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x0600870A RID: 34570 RVA: 0x00145EC7 File Offset: 0x001440C7
		// (set) Token: 0x0600870B RID: 34571 RVA: 0x00145ECF File Offset: 0x001440CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x00145ED8 File Offset: 0x001440D8
		// (set) Token: 0x0600870D RID: 34573 RVA: 0x00145EE0 File Offset: 0x001440E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00145EE9 File Offset: 0x001440E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshGachaRequest);
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00145EF8 File Offset: 0x001440F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00145F54 File Offset: 0x00144154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00145FC5 File Offset: 0x001441C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00145FD2 File Offset: 0x001441D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00145FDC File Offset: 0x001441DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00146054 File Offset: 0x00144254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x001460C4 File Offset: 0x001442C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshGachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00146128 File Offset: 0x00144328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00146134 File Offset: 0x00144334
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004323 RID: 17187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004324 RID: 17188
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04004325 RID: 17189
		private int activityId_;

		// Token: 0x04004326 RID: 17190
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x04004327 RID: 17191
		private int subInsId_;

		// Token: 0x04004328 RID: 17192
		public const int IncIdFieldNumber = 7;

		// Token: 0x04004329 RID: 17193
		private int incId_;
	}
}
