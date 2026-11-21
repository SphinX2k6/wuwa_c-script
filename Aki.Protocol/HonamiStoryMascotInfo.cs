using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000779 RID: 1913
	public sealed class HonamiStoryMascotInfo : IMessage<HonamiStoryMascotInfo>, IMessage, IEquatable<HonamiStoryMascotInfo>, IDeepCloneable<HonamiStoryMascotInfo>, IBufferMessage
	{
		// Token: 0x0600AD37 RID: 44343 RVA: 0x001A0C10 File Offset: 0x0019EE10
		[NullableContext(1)]
		public static HonamiStoryMascotInfo Create()
		{
			return new HonamiStoryMascotInfo();
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x001A0C17 File Offset: 0x0019EE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryMascotInfo> Parser
		{
			get
			{
				return HonamiStoryMascotInfo._parser;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x001A0C1E File Offset: 0x0019EE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x001A0C21 File Offset: 0x0019EE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotInfo.Descriptor;
			}
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x001A0C28 File Offset: 0x0019EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo()
		{
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x001A0C30 File Offset: 0x0019EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo(HonamiStoryMascotInfo other) : this()
		{
			this.honamiStoryMascotId_ = other.honamiStoryMascotId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x001A0C61 File Offset: 0x0019EE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo Clone()
		{
			return new HonamiStoryMascotInfo(this);
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x001A0C69 File Offset: 0x0019EE69
		// (set) Token: 0x0600AD3F RID: 44351 RVA: 0x001A0C71 File Offset: 0x0019EE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryMascotId
		{
			get
			{
				return this.honamiStoryMascotId_;
			}
			set
			{
				this.honamiStoryMascotId_ = value;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x001A0C7A File Offset: 0x0019EE7A
		// (set) Token: 0x0600AD41 RID: 44353 RVA: 0x001A0C82 File Offset: 0x0019EE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x001A0C8B File Offset: 0x0019EE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotInfo);
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x001A0C99 File Offset: 0x0019EE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryMascotId == other.HonamiStoryMascotId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x001A0CD8 File Offset: 0x0019EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryMascotId != 0)
			{
				num ^= this.HonamiStoryMascotId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x001A0D30 File Offset: 0x0019EF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x001A0D3D File Offset: 0x0019EF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x001A0D48 File Offset: 0x0019EF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryMascotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HonamiStoryMascotId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x001A0DA0 File Offset: 0x0019EFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryMascotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryMascotId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x001A0DF8 File Offset: 0x0019EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryMascotId != 0)
			{
				this.HonamiStoryMascotId = other.HonamiStoryMascotId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x001A0E48 File Offset: 0x0019F048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x001A0E54 File Offset: 0x0019F054
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.HonamiStoryMascotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EBE RID: 20158
		private static readonly MessageParser<HonamiStoryMascotInfo> _parser = new MessageParser<HonamiStoryMascotInfo>(() => new HonamiStoryMascotInfo());

		// Token: 0x04004EBF RID: 20159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC0 RID: 20160
		public const int HonamiStoryMascotIdFieldNumber = 1;

		// Token: 0x04004EC1 RID: 20161
		private int honamiStoryMascotId_;

		// Token: 0x04004EC2 RID: 20162
		public const int StatusFieldNumber = 2;

		// Token: 0x04004EC3 RID: 20163
		private int status_;
	}
}
