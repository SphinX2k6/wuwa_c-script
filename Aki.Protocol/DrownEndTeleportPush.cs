using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FB RID: 1019
	[NetMessage(EMessageId.DrownEndTeleportPush)]
	public sealed class DrownEndTeleportPush : IMessage<DrownEndTeleportPush>, IMessage, IEquatable<DrownEndTeleportPush>, IDeepCloneable<DrownEndTeleportPush>, IBufferMessage
	{
		// Token: 0x060062C6 RID: 25286 RVA: 0x000EDED7 File Offset: 0x000EC0D7
		[NullableContext(1)]
		public static DrownEndTeleportPush Create()
		{
			return new DrownEndTeleportPush();
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x000EDEDE File Offset: 0x000EC0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x000EDEE1 File Offset: 0x000EC0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportPush.Descriptor;
			}
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x000EDEE8 File Offset: 0x000EC0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush()
		{
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x000EDEF0 File Offset: 0x000EC0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush(DrownEndTeleportPush other) : this()
		{
			this.teleportPos_ = ((other.teleportPos_ != null) ? other.teleportPos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x000EDF25 File Offset: 0x000EC125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush Clone()
		{
			return new DrownEndTeleportPush(this);
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060062CC RID: 25292 RVA: 0x000EDF2D File Offset: 0x000EC12D
		// (set) Token: 0x060062CD RID: 25293 RVA: 0x000EDF35 File Offset: 0x000EC135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TeleportPos
		{
			get
			{
				return this.teleportPos_;
			}
			set
			{
				this.teleportPos_ = value;
			}
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x000EDF3E File Offset: 0x000EC13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportPush);
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x000EDF4C File Offset: 0x000EC14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportPush other)
		{
			return other != null && (other == this || (object.Equals(this.TeleportPos, other.TeleportPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x000EDF80 File Offset: 0x000EC180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.teleportPos_ != null)
			{
				num ^= this.TeleportPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x000EDFBC File Offset: 0x000EC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x000EDFC9 File Offset: 0x000EC1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x000EDFD2 File Offset: 0x000EC1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.teleportPos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TeleportPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x000EE004 File Offset: 0x000EC204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.teleportPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeleportPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x000EE044 File Offset: 0x000EC244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.teleportPos_ != null)
			{
				if (this.teleportPos_ == null)
				{
					this.TeleportPos = new Vector();
				}
				this.TeleportPos.MergeFrom(other.TeleportPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x000EE098 File Offset: 0x000EC298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x000EE0A4 File Offset: 0x000EC2A4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.teleportPos_ == null)
					{
						this.TeleportPos = new Vector();
					}
					input.ReadMessage(this.TeleportPos);
				}
			}
		}

		// Token: 0x04003850 RID: 14416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003851 RID: 14417
		public const int TeleportPosFieldNumber = 7;

		// Token: 0x04003852 RID: 14418
		private Vector teleportPos_;
	}
}
