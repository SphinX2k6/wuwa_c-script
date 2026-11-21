using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000998 RID: 2456
	[NetMessage(EMessageId.MapUnlockFieldNotify)]
	public sealed class MapUnlockFieldNotify : IMessage<MapUnlockFieldNotify>, IMessage, IEquatable<MapUnlockFieldNotify>, IDeepCloneable<MapUnlockFieldNotify>, IBufferMessage
	{
		// Token: 0x0600D7F3 RID: 55283 RVA: 0x001FBE40 File Offset: 0x001FA040
		[NullableContext(1)]
		public static MapUnlockFieldNotify Create()
		{
			return new MapUnlockFieldNotify();
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x001FBE47 File Offset: 0x001FA047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600D7F5 RID: 55285 RVA: 0x001FBE4A File Offset: 0x001FA04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldNotify.Descriptor;
			}
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x001FBE51 File Offset: 0x001FA051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify()
		{
		}

		// Token: 0x0600D7F7 RID: 55287 RVA: 0x001FBE59 File Offset: 0x001FA059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify(MapUnlockFieldNotify other) : this()
		{
			this.fieldId_ = other.fieldId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7F8 RID: 55288 RVA: 0x001FBE7E File Offset: 0x001FA07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify Clone()
		{
			return new MapUnlockFieldNotify(this);
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600D7F9 RID: 55289 RVA: 0x001FBE86 File Offset: 0x001FA086
		// (set) Token: 0x0600D7FA RID: 55290 RVA: 0x001FBE8E File Offset: 0x001FA08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FieldId
		{
			get
			{
				return this.fieldId_;
			}
			set
			{
				this.fieldId_ = value;
			}
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x001FBE97 File Offset: 0x001FA097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldNotify);
		}

		// Token: 0x0600D7FC RID: 55292 RVA: 0x001FBEA5 File Offset: 0x001FA0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldNotify other)
		{
			return other != null && (other == this || (this.FieldId == other.FieldId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x001FBED4 File Offset: 0x001FA0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FieldId != 0)
			{
				num ^= this.FieldId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7FE RID: 55294 RVA: 0x001FBF13 File Offset: 0x001FA113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7FF RID: 55295 RVA: 0x001FBF20 File Offset: 0x001FA120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D800 RID: 55296 RVA: 0x001FBF29 File Offset: 0x001FA129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FieldId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FieldId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D801 RID: 55297 RVA: 0x001FBF5C File Offset: 0x001FA15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FieldId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FieldId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D802 RID: 55298 RVA: 0x001FBF9A File Offset: 0x001FA19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapUnlockFieldNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FieldId != 0)
			{
				this.FieldId = other.FieldId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D803 RID: 55299 RVA: 0x001FBFCB File Offset: 0x001FA1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x001FBFD4 File Offset: 0x001FA1D4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FieldId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A54 RID: 23124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A55 RID: 23125
		public const int FieldIdFieldNumber = 10;

		// Token: 0x04005A56 RID: 23126
		private int fieldId_;
	}
}
