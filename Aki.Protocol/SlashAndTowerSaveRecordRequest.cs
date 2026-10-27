using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001251 RID: 4689
	[NetMessage(EMessageId.SlashAndTowerSaveRecordRequest)]
	public sealed class SlashAndTowerSaveRecordRequest : IMessage<SlashAndTowerSaveRecordRequest>, IMessage, IEquatable<SlashAndTowerSaveRecordRequest>, IDeepCloneable<SlashAndTowerSaveRecordRequest>, IBufferMessage
	{
		// Token: 0x06018FBD RID: 102333 RVA: 0x003A2A12 File Offset: 0x003A0C12
		[NullableContext(1)]
		public static SlashAndTowerSaveRecordRequest Create()
		{
			return new SlashAndTowerSaveRecordRequest();
		}

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x06018FBE RID: 102334 RVA: 0x003A2A19 File Offset: 0x003A0C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x06018FBF RID: 102335 RVA: 0x003A2A1C File Offset: 0x003A0C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerSaveRecordRequest.Descriptor;
			}
		}

		// Token: 0x06018FC0 RID: 102336 RVA: 0x003A2A23 File Offset: 0x003A0C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest()
		{
		}

		// Token: 0x06018FC1 RID: 102337 RVA: 0x003A2A2B File Offset: 0x003A0C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest(SlashAndTowerSaveRecordRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FC2 RID: 102338 RVA: 0x003A2A50 File Offset: 0x003A0C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest Clone()
		{
			return new SlashAndTowerSaveRecordRequest(this);
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x06018FC3 RID: 102339 RVA: 0x003A2A58 File Offset: 0x003A0C58
		// (set) Token: 0x06018FC4 RID: 102340 RVA: 0x003A2A60 File Offset: 0x003A0C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x06018FC5 RID: 102341 RVA: 0x003A2A69 File Offset: 0x003A0C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerSaveRecordRequest);
		}

		// Token: 0x06018FC6 RID: 102342 RVA: 0x003A2A77 File Offset: 0x003A0C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerSaveRecordRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FC7 RID: 102343 RVA: 0x003A2AA8 File Offset: 0x003A0CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FC8 RID: 102344 RVA: 0x003A2AE7 File Offset: 0x003A0CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FC9 RID: 102345 RVA: 0x003A2AF4 File Offset: 0x003A0CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FCA RID: 102346 RVA: 0x003A2AFD File Offset: 0x003A0CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FCB RID: 102347 RVA: 0x003A2B30 File Offset: 0x003A0D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FCC RID: 102348 RVA: 0x003A2B6E File Offset: 0x003A0D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerSaveRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FCD RID: 102349 RVA: 0x003A2B9F File Offset: 0x003A0D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FCE RID: 102350 RVA: 0x003A2BA8 File Offset: 0x003A0DA8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009343 RID: 37699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009344 RID: 37700
		public const int IdFieldNumber = 6;

		// Token: 0x04009345 RID: 37701
		private int id_;
	}
}
