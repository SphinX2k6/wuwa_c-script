using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A9 RID: 2473
	[NetMessage(EMessageId.MapUnlockFieldNotify)]
	public sealed class MapUnlockFieldNotify : IMessage<MapUnlockFieldNotify>, IMessage, IEquatable<MapUnlockFieldNotify>, IDeepCloneable<MapUnlockFieldNotify>, IBufferMessage
	{
		// Token: 0x0600D90D RID: 55565 RVA: 0x001FE034 File Offset: 0x001FC234
		[NullableContext(1)]
		public static MapUnlockFieldNotify Create()
		{
			return new MapUnlockFieldNotify();
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0600D90E RID: 55566 RVA: 0x001FE03B File Offset: 0x001FC23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0600D90F RID: 55567 RVA: 0x001FE03E File Offset: 0x001FC23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldNotify.Descriptor;
			}
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x001FE045 File Offset: 0x001FC245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify()
		{
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x001FE04D File Offset: 0x001FC24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify(MapUnlockFieldNotify other) : this()
		{
			this.fieldId_ = other.fieldId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D912 RID: 55570 RVA: 0x001FE072 File Offset: 0x001FC272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldNotify Clone()
		{
			return new MapUnlockFieldNotify(this);
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600D913 RID: 55571 RVA: 0x001FE07A File Offset: 0x001FC27A
		// (set) Token: 0x0600D914 RID: 55572 RVA: 0x001FE082 File Offset: 0x001FC282
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

		// Token: 0x0600D915 RID: 55573 RVA: 0x001FE08B File Offset: 0x001FC28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldNotify);
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x001FE099 File Offset: 0x001FC299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldNotify other)
		{
			return other != null && (other == this || (this.FieldId == other.FieldId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D917 RID: 55575 RVA: 0x001FE0C8 File Offset: 0x001FC2C8
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

		// Token: 0x0600D918 RID: 55576 RVA: 0x001FE107 File Offset: 0x001FC307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D919 RID: 55577 RVA: 0x001FE114 File Offset: 0x001FC314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x001FE11D File Offset: 0x001FC31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FieldId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FieldId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D91B RID: 55579 RVA: 0x001FE150 File Offset: 0x001FC350
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

		// Token: 0x0600D91C RID: 55580 RVA: 0x001FE18E File Offset: 0x001FC38E
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

		// Token: 0x0600D91D RID: 55581 RVA: 0x001FE1BF File Offset: 0x001FC3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x001FE1C8 File Offset: 0x001FC3C8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FieldId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A4B RID: 23115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A4C RID: 23116
		public const int FieldIdFieldNumber = 4;

		// Token: 0x04005A4D RID: 23117
		private int fieldId_;
	}
}
