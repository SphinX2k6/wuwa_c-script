using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133F RID: 4927
	[NetMessage(EMessageId.TeleportToTargetRequest)]
	public sealed class TeleportToTargetRequest : IMessage<TeleportToTargetRequest>, IMessage, IEquatable<TeleportToTargetRequest>, IDeepCloneable<TeleportToTargetRequest>, IBufferMessage
	{
		// Token: 0x0601A2C9 RID: 107209 RVA: 0x003CD2C8 File Offset: 0x003CB4C8
		[NullableContext(1)]
		public static TeleportToTargetRequest Create()
		{
			return new TeleportToTargetRequest();
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x0601A2CA RID: 107210 RVA: 0x003CD2CF File Offset: 0x003CB4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x0601A2CB RID: 107211 RVA: 0x003CD2D2 File Offset: 0x003CB4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToTargetRequest.Descriptor;
			}
		}

		// Token: 0x0601A2CC RID: 107212 RVA: 0x003CD2D9 File Offset: 0x003CB4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest()
		{
		}

		// Token: 0x0601A2CD RID: 107213 RVA: 0x003CD2E4 File Offset: 0x003CB4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest(TeleportToTargetRequest other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2CE RID: 107214 RVA: 0x003CD330 File Offset: 0x003CB530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest Clone()
		{
			return new TeleportToTargetRequest(this);
		}

		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x0601A2CF RID: 107215 RVA: 0x003CD338 File Offset: 0x003CB538
		// (set) Token: 0x0601A2D0 RID: 107216 RVA: 0x003CD340 File Offset: 0x003CB540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x0601A2D1 RID: 107217 RVA: 0x003CD349 File Offset: 0x003CB549
		// (set) Token: 0x0601A2D2 RID: 107218 RVA: 0x003CD351 File Offset: 0x003CB551
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

		// Token: 0x0601A2D3 RID: 107219 RVA: 0x003CD35A File Offset: 0x003CB55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToTargetRequest);
		}

		// Token: 0x0601A2D4 RID: 107220 RVA: 0x003CD368 File Offset: 0x003CB568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToTargetRequest other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2D5 RID: 107221 RVA: 0x003CD3B8 File Offset: 0x003CB5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
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

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x003CD40D File Offset: 0x003CB60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x003CD41A File Offset: 0x003CB61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2D8 RID: 107224 RVA: 0x003CD424 File Offset: 0x003CB624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rot);
			}
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2D9 RID: 107225 RVA: 0x003CD480 File Offset: 0x003CB680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
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

		// Token: 0x0601A2DA RID: 107226 RVA: 0x003CD4D8 File Offset: 0x003CB6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
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

		// Token: 0x0601A2DB RID: 107227 RVA: 0x003CD540 File Offset: 0x003CB740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2DC RID: 107228 RVA: 0x003CD54C File Offset: 0x003CB74C
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
				if (num != 26U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TemporaryTeleportId = input.ReadInt64();
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

		// Token: 0x040098B2 RID: 39090
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098B3 RID: 39091
		public const int TemporaryTeleportIdFieldNumber = 5;

		// Token: 0x040098B4 RID: 39092
		private long temporaryTeleportId_;

		// Token: 0x040098B5 RID: 39093
		public const int RotFieldNumber = 3;

		// Token: 0x040098B6 RID: 39094
		private Rotator rot_;
	}
}
