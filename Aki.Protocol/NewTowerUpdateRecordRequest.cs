using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B53 RID: 2899
	[NetMessage(EMessageId.NewTowerUpdateRecordRequest)]
	public sealed class NewTowerUpdateRecordRequest : IMessage<NewTowerUpdateRecordRequest>, IMessage, IEquatable<NewTowerUpdateRecordRequest>, IDeepCloneable<NewTowerUpdateRecordRequest>, IBufferMessage
	{
		// Token: 0x0600FB55 RID: 64341 RVA: 0x00249F5C File Offset: 0x0024815C
		[NullableContext(1)]
		public static NewTowerUpdateRecordRequest Create()
		{
			return new NewTowerUpdateRecordRequest();
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600FB56 RID: 64342 RVA: 0x00249F63 File Offset: 0x00248163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600FB57 RID: 64343 RVA: 0x00249F66 File Offset: 0x00248166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600FB58 RID: 64344 RVA: 0x00249F6D File Offset: 0x0024816D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest()
		{
		}

		// Token: 0x0600FB59 RID: 64345 RVA: 0x00249F75 File Offset: 0x00248175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest(NewTowerUpdateRecordRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB5A RID: 64346 RVA: 0x00249F9A File Offset: 0x0024819A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordRequest Clone()
		{
			return new NewTowerUpdateRecordRequest(this);
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600FB5B RID: 64347 RVA: 0x00249FA2 File Offset: 0x002481A2
		// (set) Token: 0x0600FB5C RID: 64348 RVA: 0x00249FAA File Offset: 0x002481AA
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

		// Token: 0x0600FB5D RID: 64349 RVA: 0x00249FB3 File Offset: 0x002481B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordRequest);
		}

		// Token: 0x0600FB5E RID: 64350 RVA: 0x00249FC1 File Offset: 0x002481C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB5F RID: 64351 RVA: 0x00249FF0 File Offset: 0x002481F0
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

		// Token: 0x0600FB60 RID: 64352 RVA: 0x0024A02F File Offset: 0x0024822F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB61 RID: 64353 RVA: 0x0024A03C File Offset: 0x0024823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB62 RID: 64354 RVA: 0x0024A045 File Offset: 0x00248245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB63 RID: 64355 RVA: 0x0024A078 File Offset: 0x00248278
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

		// Token: 0x0600FB64 RID: 64356 RVA: 0x0024A0B6 File Offset: 0x002482B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordRequest other)
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

		// Token: 0x0600FB65 RID: 64357 RVA: 0x0024A0E7 File Offset: 0x002482E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB66 RID: 64358 RVA: 0x0024A0F0 File Offset: 0x002482F0
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
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400647D RID: 25725
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400647E RID: 25726
		public const int LevelIdFieldNumber = 6;

		// Token: 0x0400647F RID: 25727
		private int levelId_;
	}
}
