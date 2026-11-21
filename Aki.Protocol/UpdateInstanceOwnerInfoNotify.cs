using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150E RID: 5390
	[NetMessage(EMessageId.UpdateInstanceOwnerInfoNotify)]
	public sealed class UpdateInstanceOwnerInfoNotify : IMessage<UpdateInstanceOwnerInfoNotify>, IMessage, IEquatable<UpdateInstanceOwnerInfoNotify>, IDeepCloneable<UpdateInstanceOwnerInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C8F8 RID: 116984 RVA: 0x00423A72 File Offset: 0x00421C72
		[NullableContext(1)]
		public static UpdateInstanceOwnerInfoNotify Create()
		{
			return new UpdateInstanceOwnerInfoNotify();
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x0601C8F9 RID: 116985 RVA: 0x00423A79 File Offset: 0x00421C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x0601C8FA RID: 116986 RVA: 0x00423A7C File Offset: 0x00421C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateInstanceOwnerInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C8FB RID: 116987 RVA: 0x00423A83 File Offset: 0x00421C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify()
		{
		}

		// Token: 0x0601C8FC RID: 116988 RVA: 0x00423A8C File Offset: 0x00421C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify(UpdateInstanceOwnerInfoNotify other) : this()
		{
			this.id_ = other.id_;
			this.instanceOwnerInfo_ = ((other.instanceOwnerInfo_ != null) ? other.instanceOwnerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8FD RID: 116989 RVA: 0x00423AD8 File Offset: 0x00421CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify Clone()
		{
			return new UpdateInstanceOwnerInfoNotify(this);
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x0601C8FE RID: 116990 RVA: 0x00423AE0 File Offset: 0x00421CE0
		// (set) Token: 0x0601C8FF RID: 116991 RVA: 0x00423AE8 File Offset: 0x00421CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x0601C900 RID: 116992 RVA: 0x00423AF1 File Offset: 0x00421CF1
		// (set) Token: 0x0601C901 RID: 116993 RVA: 0x00423AF9 File Offset: 0x00421CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo InstanceOwnerInfo
		{
			get
			{
				return this.instanceOwnerInfo_;
			}
			set
			{
				this.instanceOwnerInfo_ = value;
			}
		}

		// Token: 0x0601C902 RID: 116994 RVA: 0x00423B02 File Offset: 0x00421D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateInstanceOwnerInfoNotify);
		}

		// Token: 0x0601C903 RID: 116995 RVA: 0x00423B10 File Offset: 0x00421D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateInstanceOwnerInfoNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.InstanceOwnerInfo, other.InstanceOwnerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C904 RID: 116996 RVA: 0x00423B60 File Offset: 0x00421D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.instanceOwnerInfo_ != null)
			{
				num ^= this.InstanceOwnerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C905 RID: 116997 RVA: 0x00423BB5 File Offset: 0x00421DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C906 RID: 116998 RVA: 0x00423BC2 File Offset: 0x00421DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C907 RID: 116999 RVA: 0x00423BCC File Offset: 0x00421DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.instanceOwnerInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InstanceOwnerInfo);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x00423C28 File Offset: 0x00421E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.instanceOwnerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstanceOwnerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C909 RID: 117001 RVA: 0x00423C80 File Offset: 0x00421E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateInstanceOwnerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.instanceOwnerInfo_ != null)
			{
				if (this.instanceOwnerInfo_ == null)
				{
					this.InstanceOwnerInfo = new InstanceOwnerInfo();
				}
				this.InstanceOwnerInfo.MergeFrom(other.InstanceOwnerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C90A RID: 117002 RVA: 0x00423CE8 File Offset: 0x00421EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C90B RID: 117003 RVA: 0x00423CF4 File Offset: 0x00421EF4
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
				if (num != 34U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					if (this.instanceOwnerInfo_ == null)
					{
						this.InstanceOwnerInfo = new InstanceOwnerInfo();
					}
					input.ReadMessage(this.InstanceOwnerInfo);
				}
			}
		}

		// Token: 0x0400A4A5 RID: 42149
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4A6 RID: 42150
		public const int IdFieldNumber = 8;

		// Token: 0x0400A4A7 RID: 42151
		private long id_;

		// Token: 0x0400A4A8 RID: 42152
		public const int InstanceOwnerInfoFieldNumber = 4;

		// Token: 0x0400A4A9 RID: 42153
		private InstanceOwnerInfo instanceOwnerInfo_;
	}
}
