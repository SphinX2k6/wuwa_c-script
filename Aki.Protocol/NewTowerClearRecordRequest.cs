using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1B RID: 2843
	[NetMessage(EMessageId.NewTowerClearRecordRequest)]
	public sealed class NewTowerClearRecordRequest : IMessage<NewTowerClearRecordRequest>, IMessage, IEquatable<NewTowerClearRecordRequest>, IDeepCloneable<NewTowerClearRecordRequest>, IBufferMessage
	{
		// Token: 0x0600F726 RID: 63270 RVA: 0x0024110C File Offset: 0x0023F30C
		[NullableContext(1)]
		public static NewTowerClearRecordRequest Create()
		{
			return new NewTowerClearRecordRequest();
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600F727 RID: 63271 RVA: 0x00241113 File Offset: 0x0023F313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x00241116 File Offset: 0x0023F316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClearRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600F729 RID: 63273 RVA: 0x0024111D File Offset: 0x0023F31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest()
		{
		}

		// Token: 0x0600F72A RID: 63274 RVA: 0x00241125 File Offset: 0x0023F325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest(NewTowerClearRecordRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x0024114A File Offset: 0x0023F34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordRequest Clone()
		{
			return new NewTowerClearRecordRequest(this);
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600F72C RID: 63276 RVA: 0x00241152 File Offset: 0x0023F352
		// (set) Token: 0x0600F72D RID: 63277 RVA: 0x0024115A File Offset: 0x0023F35A
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

		// Token: 0x0600F72E RID: 63278 RVA: 0x00241163 File Offset: 0x0023F363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClearRecordRequest);
		}

		// Token: 0x0600F72F RID: 63279 RVA: 0x00241171 File Offset: 0x0023F371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClearRecordRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F730 RID: 63280 RVA: 0x002411A0 File Offset: 0x0023F3A0
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

		// Token: 0x0600F731 RID: 63281 RVA: 0x002411DF File Offset: 0x0023F3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x002411EC File Offset: 0x0023F3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x002411F5 File Offset: 0x0023F3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x00241228 File Offset: 0x0023F428
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

		// Token: 0x0600F735 RID: 63285 RVA: 0x00241266 File Offset: 0x0023F466
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

		// Token: 0x0600F736 RID: 63286 RVA: 0x00241297 File Offset: 0x0023F497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F737 RID: 63287 RVA: 0x002412A0 File Offset: 0x0023F4A0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006391 RID: 25489
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006392 RID: 25490
		public const int LevelIdFieldNumber = 7;

		// Token: 0x04006393 RID: 25491
		private int levelId_;
	}
}
