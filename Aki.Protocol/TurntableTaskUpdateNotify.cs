using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001472 RID: 5234
	[NetMessage(EMessageId.TurntableTaskUpdateNotify)]
	public sealed class TurntableTaskUpdateNotify : IMessage<TurntableTaskUpdateNotify>, IMessage, IEquatable<TurntableTaskUpdateNotify>, IDeepCloneable<TurntableTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BB54 RID: 113492 RVA: 0x0040281C File Offset: 0x00400A1C
		[NullableContext(1)]
		public static TurntableTaskUpdateNotify Create()
		{
			return new TurntableTaskUpdateNotify();
		}

		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x0601BB55 RID: 113493 RVA: 0x00402823 File Offset: 0x00400A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x0601BB56 RID: 113494 RVA: 0x00402826 File Offset: 0x00400A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BB57 RID: 113495 RVA: 0x0040282D File Offset: 0x00400A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify()
		{
		}

		// Token: 0x0601BB58 RID: 113496 RVA: 0x00402835 File Offset: 0x00400A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify(TurntableTaskUpdateNotify other) : this()
		{
			this.turntableTask_ = ((other.turntableTask_ != null) ? other.turntableTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB59 RID: 113497 RVA: 0x0040286A File Offset: 0x00400A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify Clone()
		{
			return new TurntableTaskUpdateNotify(this);
		}

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x0601BB5A RID: 113498 RVA: 0x00402872 File Offset: 0x00400A72
		// (set) Token: 0x0601BB5B RID: 113499 RVA: 0x0040287A File Offset: 0x00400A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask TurntableTask
		{
			get
			{
				return this.turntableTask_;
			}
			set
			{
				this.turntableTask_ = value;
			}
		}

		// Token: 0x0601BB5C RID: 113500 RVA: 0x00402883 File Offset: 0x00400A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableTaskUpdateNotify);
		}

		// Token: 0x0601BB5D RID: 113501 RVA: 0x00402891 File Offset: 0x00400A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TurntableTask, other.TurntableTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB5E RID: 113502 RVA: 0x004028C4 File Offset: 0x00400AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.turntableTask_ != null)
			{
				num ^= this.TurntableTask.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB5F RID: 113503 RVA: 0x00402900 File Offset: 0x00400B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB60 RID: 113504 RVA: 0x0040290D File Offset: 0x00400B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB61 RID: 113505 RVA: 0x00402916 File Offset: 0x00400B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.turntableTask_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TurntableTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB62 RID: 113506 RVA: 0x00402948 File Offset: 0x00400B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.turntableTask_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TurntableTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB63 RID: 113507 RVA: 0x00402988 File Offset: 0x00400B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.turntableTask_ != null)
			{
				if (this.turntableTask_ == null)
				{
					this.TurntableTask = new ActivityTask();
				}
				this.TurntableTask.MergeFrom(other.TurntableTask);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB64 RID: 113508 RVA: 0x004029DC File Offset: 0x00400BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB65 RID: 113509 RVA: 0x004029E8 File Offset: 0x00400BE8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.turntableTask_ == null)
					{
						this.TurntableTask = new ActivityTask();
					}
					input.ReadMessage(this.TurntableTask);
				}
			}
		}

		// Token: 0x04009F9C RID: 40860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F9D RID: 40861
		public const int TurntableTaskFieldNumber = 9;

		// Token: 0x04009F9E RID: 40862
		private ActivityTask turntableTask_;
	}
}
