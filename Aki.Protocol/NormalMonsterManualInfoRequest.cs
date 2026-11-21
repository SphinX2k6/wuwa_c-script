using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B51 RID: 2897
	[NetMessage(EMessageId.NormalMonsterManualInfoRequest)]
	public sealed class NormalMonsterManualInfoRequest : IMessage<NormalMonsterManualInfoRequest>, IMessage, IEquatable<NormalMonsterManualInfoRequest>, IDeepCloneable<NormalMonsterManualInfoRequest>, IBufferMessage
	{
		// Token: 0x0600FB62 RID: 64354 RVA: 0x0024A1C8 File Offset: 0x002483C8
		[NullableContext(1)]
		public static NormalMonsterManualInfoRequest Create()
		{
			return new NormalMonsterManualInfoRequest();
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600FB63 RID: 64355 RVA: 0x0024A1CF File Offset: 0x002483CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600FB64 RID: 64356 RVA: 0x0024A1D2 File Offset: 0x002483D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalMonsterManualInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600FB65 RID: 64357 RVA: 0x0024A1D9 File Offset: 0x002483D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest()
		{
		}

		// Token: 0x0600FB66 RID: 64358 RVA: 0x0024A1E1 File Offset: 0x002483E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest(NormalMonsterManualInfoRequest other) : this()
		{
			this.detectionId_ = other.detectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB67 RID: 64359 RVA: 0x0024A206 File Offset: 0x00248406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest Clone()
		{
			return new NormalMonsterManualInfoRequest(this);
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600FB68 RID: 64360 RVA: 0x0024A20E File Offset: 0x0024840E
		// (set) Token: 0x0600FB69 RID: 64361 RVA: 0x0024A216 File Offset: 0x00248416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x0600FB6A RID: 64362 RVA: 0x0024A21F File Offset: 0x0024841F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalMonsterManualInfoRequest);
		}

		// Token: 0x0600FB6B RID: 64363 RVA: 0x0024A22D File Offset: 0x0024842D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalMonsterManualInfoRequest other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB6C RID: 64364 RVA: 0x0024A25C File Offset: 0x0024845C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB6D RID: 64365 RVA: 0x0024A29B File Offset: 0x0024849B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB6E RID: 64366 RVA: 0x0024A2A8 File Offset: 0x002484A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB6F RID: 64367 RVA: 0x0024A2B1 File Offset: 0x002484B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DetectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB70 RID: 64368 RVA: 0x0024A2E4 File Offset: 0x002484E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB71 RID: 64369 RVA: 0x0024A322 File Offset: 0x00248522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalMonsterManualInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB72 RID: 64370 RVA: 0x0024A353 File Offset: 0x00248553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB73 RID: 64371 RVA: 0x0024A35C File Offset: 0x0024855C
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
					this.DetectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064CF RID: 25807
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064D0 RID: 25808
		public const int DetectionIdFieldNumber = 5;

		// Token: 0x040064D1 RID: 25809
		private int detectionId_;
	}
}
