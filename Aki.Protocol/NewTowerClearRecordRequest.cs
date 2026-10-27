using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2C RID: 2860
	[NetMessage(EMessageId.NewTowerClearRecordRequest)]
	public sealed class NewTowerClearRecordRequest : IMessage<NewTowerClearRecordRequest>, IMessage, IEquatable<NewTowerClearRecordRequest>, IDeepCloneable<NewTowerClearRecordRequest>, IBufferMessage
	{
		// Token: 0x0600F840 RID: 63552 RVA: 0x00243328 File Offset: 0x00241528
		[NullableContext(1)]
		public static NewTowerClearRecordRequest Create()
		{
			return new NewTowerClearRecordRequest();
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600F841 RID: 63553 RVA: 0x0024332F File Offset: 0x0024152F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600F842 RID: 63554 RVA: 0x00243332 File Offset: 0x00241532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClearRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600F843 RID: 63555 RVA: 0x00243339 File Offset: 0x00241539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest()
		{
		}

		// Token: 0x0600F844 RID: 63556 RVA: 0x00243341 File Offset: 0x00241541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest(NewTowerClearRecordRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F845 RID: 63557 RVA: 0x00243366 File Offset: 0x00241566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest Clone()
		{
			return new NewTowerClearRecordRequest(this);
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x0024336E File Offset: 0x0024156E
		// (set) Token: 0x0600F847 RID: 63559 RVA: 0x00243376 File Offset: 0x00241576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0600F848 RID: 63560 RVA: 0x0024337F File Offset: 0x0024157F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClearRecordRequest);
		}

		// Token: 0x0600F849 RID: 63561 RVA: 0x0024338D File Offset: 0x0024158D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClearRecordRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F84A RID: 63562 RVA: 0x002433BC File Offset: 0x002415BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F84B RID: 63563 RVA: 0x002433FB File Offset: 0x002415FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F84C RID: 63564 RVA: 0x00243408 File Offset: 0x00241608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F84D RID: 63565 RVA: 0x00243411 File Offset: 0x00241611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x00243444 File Offset: 0x00241644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x00243482 File Offset: 0x00241682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClearRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x002434B3 File Offset: 0x002416B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F851 RID: 63569 RVA: 0x002434BC File Offset: 0x002416BC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006388 RID: 25480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006389 RID: 25481
		public const int LevelIdFieldNumber = 3;

		// Token: 0x0400638A RID: 25482
		private int levelId_;
	}
}
