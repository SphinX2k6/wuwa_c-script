using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F8 RID: 2552
	[NetMessage(EMessageId.MontagePlayRequest)]
	public sealed class MontagePlayRequest : IMessage<MontagePlayRequest>, IMessage, IEquatable<MontagePlayRequest>, IDeepCloneable<MontagePlayRequest>, IBufferMessage
	{
		// Token: 0x0600DFAE RID: 57262 RVA: 0x0020CC2C File Offset: 0x0020AE2C
		[NullableContext(1)]
		public static MontagePlayRequest Create()
		{
			return new MontagePlayRequest();
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600DFAF RID: 57263 RVA: 0x0020CC33 File Offset: 0x0020AE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600DFB0 RID: 57264 RVA: 0x0020CC36 File Offset: 0x0020AE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayRequest.Descriptor;
			}
		}

		// Token: 0x0600DFB1 RID: 57265 RVA: 0x0020CC3D File Offset: 0x0020AE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest()
		{
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x0020CC45 File Offset: 0x0020AE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest(MontagePlayRequest other) : this()
		{
			this.montageIndex_ = other.montageIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x0020CC6A File Offset: 0x0020AE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest Clone()
		{
			return new MontagePlayRequest(this);
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x0020CC72 File Offset: 0x0020AE72
		// (set) Token: 0x0600DFB5 RID: 57269 RVA: 0x0020CC7A File Offset: 0x0020AE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x0020CC83 File Offset: 0x0020AE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayRequest);
		}

		// Token: 0x0600DFB7 RID: 57271 RVA: 0x0020CC91 File Offset: 0x0020AE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayRequest other)
		{
			return other != null && (other == this || (this.MontageIndex == other.MontageIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x0020CCC0 File Offset: 0x0020AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x0020CCFF File Offset: 0x0020AEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x0020CD0C File Offset: 0x0020AF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFBB RID: 57275 RVA: 0x0020CD15 File Offset: 0x0020AF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFBC RID: 57276 RVA: 0x0020CD48 File Offset: 0x0020AF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x0020CD86 File Offset: 0x0020AF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x0020CDB7 File Offset: 0x0020AFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x0020CDC0 File Offset: 0x0020AFC0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MontageIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C82 RID: 23682
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C83 RID: 23683
		public const int MontageIndexFieldNumber = 9;

		// Token: 0x04005C84 RID: 23684
		private int montageIndex_;
	}
}
