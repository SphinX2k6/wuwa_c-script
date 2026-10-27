using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1E RID: 3358
	[NetMessage(EMessageId.PhBaPlanSetFiveStarSwitchResponse)]
	public sealed class PhBaPlanSetFiveStarSwitchResponse : IMessage<PhBaPlanSetFiveStarSwitchResponse>, IMessage, IEquatable<PhBaPlanSetFiveStarSwitchResponse>, IDeepCloneable<PhBaPlanSetFiveStarSwitchResponse>, IBufferMessage
	{
		// Token: 0x0601222F RID: 74287 RVA: 0x002A6405 File Offset: 0x002A4605
		[NullableContext(1)]
		public static PhBaPlanSetFiveStarSwitchResponse Create()
		{
			return new PhBaPlanSetFiveStarSwitchResponse();
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x06012230 RID: 74288 RVA: 0x002A640C File Offset: 0x002A460C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x06012231 RID: 74289 RVA: 0x002A640F File Offset: 0x002A460F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetFiveStarSwitchResponse.Descriptor;
			}
		}

		// Token: 0x06012232 RID: 74290 RVA: 0x002A6416 File Offset: 0x002A4616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse()
		{
		}

		// Token: 0x06012233 RID: 74291 RVA: 0x002A641E File Offset: 0x002A461E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse(PhBaPlanSetFiveStarSwitchResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012234 RID: 74292 RVA: 0x002A6443 File Offset: 0x002A4643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchResponse Clone()
		{
			return new PhBaPlanSetFiveStarSwitchResponse(this);
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x06012235 RID: 74293 RVA: 0x002A644B File Offset: 0x002A464B
		// (set) Token: 0x06012236 RID: 74294 RVA: 0x002A6453 File Offset: 0x002A4653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06012237 RID: 74295 RVA: 0x002A645C File Offset: 0x002A465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetFiveStarSwitchResponse);
		}

		// Token: 0x06012238 RID: 74296 RVA: 0x002A646A File Offset: 0x002A466A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetFiveStarSwitchResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012239 RID: 74297 RVA: 0x002A6498 File Offset: 0x002A4698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601223A RID: 74298 RVA: 0x002A64DD File Offset: 0x002A46DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601223B RID: 74299 RVA: 0x002A64EA File Offset: 0x002A46EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601223C RID: 74300 RVA: 0x002A64F3 File Offset: 0x002A46F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601223D RID: 74301 RVA: 0x002A6528 File Offset: 0x002A4728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601223E RID: 74302 RVA: 0x002A6566 File Offset: 0x002A4766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetFiveStarSwitchResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601223F RID: 74303 RVA: 0x002A6597 File Offset: 0x002A4797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012240 RID: 74304 RVA: 0x002A65A0 File Offset: 0x002A47A0
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400715B RID: 29019
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400715C RID: 29020
		public const int CodeFieldNumber = 4;

		// Token: 0x0400715D RID: 29021
		private ErrorCode code_;
	}
}
