using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000972 RID: 2418
	[NetMessage(EMessageId.MapCancelTraceNotify)]
	public sealed class MapCancelTraceNotify : IMessage<MapCancelTraceNotify>, IMessage, IEquatable<MapCancelTraceNotify>, IDeepCloneable<MapCancelTraceNotify>, IBufferMessage
	{
		// Token: 0x0600D508 RID: 54536 RVA: 0x001F5CB8 File Offset: 0x001F3EB8
		[NullableContext(1)]
		public static MapCancelTraceNotify Create()
		{
			return new MapCancelTraceNotify();
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600D509 RID: 54537 RVA: 0x001F5CBF File Offset: 0x001F3EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x001F5CC2 File Offset: 0x001F3EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceNotify.Descriptor;
			}
		}

		// Token: 0x0600D50B RID: 54539 RVA: 0x001F5CC9 File Offset: 0x001F3EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify()
		{
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x001F5CD1 File Offset: 0x001F3ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify(MapCancelTraceNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x001F5CF6 File Offset: 0x001F3EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify Clone()
		{
			return new MapCancelTraceNotify(this);
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x001F5CFE File Offset: 0x001F3EFE
		// (set) Token: 0x0600D50F RID: 54543 RVA: 0x001F5D06 File Offset: 0x001F3F06
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

		// Token: 0x0600D510 RID: 54544 RVA: 0x001F5D0F File Offset: 0x001F3F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceNotify);
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x001F5D1D File Offset: 0x001F3F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x001F5D4C File Offset: 0x001F3F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D513 RID: 54547 RVA: 0x001F5D8B File Offset: 0x001F3F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D514 RID: 54548 RVA: 0x001F5D98 File Offset: 0x001F3F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x001F5DA1 File Offset: 0x001F3FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D516 RID: 54550 RVA: 0x001F5DD4 File Offset: 0x001F3FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D517 RID: 54551 RVA: 0x001F5E12 File Offset: 0x001F4012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCancelTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D518 RID: 54552 RVA: 0x001F5E43 File Offset: 0x001F4043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x001F5E4C File Offset: 0x001F404C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005993 RID: 22931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005994 RID: 22932
		public const int MarkIdFieldNumber = 5;

		// Token: 0x04005995 RID: 22933
		private int markId_;
	}
}
