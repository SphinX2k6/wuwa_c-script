using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099A RID: 2458
	[NetMessage(EMessageId.MapTraceNotify)]
	public sealed class MapTraceNotify : IMessage<MapTraceNotify>, IMessage, IEquatable<MapTraceNotify>, IDeepCloneable<MapTraceNotify>, IBufferMessage
	{
		// Token: 0x0600D7EE RID: 55278 RVA: 0x001FBD60 File Offset: 0x001F9F60
		[NullableContext(1)]
		public static MapTraceNotify Create()
		{
			return new MapTraceNotify();
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0600D7EF RID: 55279 RVA: 0x001FBD67 File Offset: 0x001F9F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600D7F0 RID: 55280 RVA: 0x001FBD6A File Offset: 0x001F9F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceNotify.Descriptor;
			}
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x001FBD71 File Offset: 0x001F9F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify()
		{
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x001FBD79 File Offset: 0x001F9F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify(MapTraceNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7F3 RID: 55283 RVA: 0x001FBD9E File Offset: 0x001F9F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify Clone()
		{
			return new MapTraceNotify(this);
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x001FBDA6 File Offset: 0x001F9FA6
		// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x001FBDAE File Offset: 0x001F9FAE
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

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x001FBDB7 File Offset: 0x001F9FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceNotify);
		}

		// Token: 0x0600D7F7 RID: 55287 RVA: 0x001FBDC5 File Offset: 0x001F9FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7F8 RID: 55288 RVA: 0x001FBDF4 File Offset: 0x001F9FF4
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

		// Token: 0x0600D7F9 RID: 55289 RVA: 0x001FBE33 File Offset: 0x001FA033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7FA RID: 55290 RVA: 0x001FBE40 File Offset: 0x001FA040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x001FBE49 File Offset: 0x001FA049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7FC RID: 55292 RVA: 0x001FBE7C File Offset: 0x001FA07C
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

		// Token: 0x0600D7FD RID: 55293 RVA: 0x001FBEBA File Offset: 0x001FA0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceNotify other)
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

		// Token: 0x0600D7FE RID: 55294 RVA: 0x001FBEEB File Offset: 0x001FA0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7FF RID: 55295 RVA: 0x001FBEF4 File Offset: 0x001FA0F4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A0D RID: 23053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A0E RID: 23054
		public const int MarkIdFieldNumber = 11;

		// Token: 0x04005A0F RID: 23055
		private int markId_;
	}
}
