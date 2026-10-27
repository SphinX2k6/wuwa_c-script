using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FD RID: 2557
	[NetMessage(EMessageId.MonsterDrownResponse)]
	public sealed class MonsterDrownResponse : IMessage<MonsterDrownResponse>, IMessage, IEquatable<MonsterDrownResponse>, IDeepCloneable<MonsterDrownResponse>, IBufferMessage
	{
		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0020CEC0 File Offset: 0x0020B0C0
		[NullableContext(1)]
		public static MonsterDrownResponse Create()
		{
			return new MonsterDrownResponse();
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600DFD5 RID: 57301 RVA: 0x0020CEC7 File Offset: 0x0020B0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x0020CECA File Offset: 0x0020B0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownResponse.Descriptor;
			}
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x0020CED1 File Offset: 0x0020B0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse()
		{
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x0020CED9 File Offset: 0x0020B0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse(MonsterDrownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x0020CEFE File Offset: 0x0020B0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse Clone()
		{
			return new MonsterDrownResponse(this);
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600DFDA RID: 57306 RVA: 0x0020CF06 File Offset: 0x0020B106
		// (set) Token: 0x0600DFDB RID: 57307 RVA: 0x0020CF0E File Offset: 0x0020B10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600DFDC RID: 57308 RVA: 0x0020CF17 File Offset: 0x0020B117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownResponse);
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x0020CF25 File Offset: 0x0020B125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x0020CF54 File Offset: 0x0020B154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x0020CF99 File Offset: 0x0020B199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x0020CFA6 File Offset: 0x0020B1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x0020CFAF File Offset: 0x0020B1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x0020CFE4 File Offset: 0x0020B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x0020D022 File Offset: 0x0020B222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDrownResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x0020D053 File Offset: 0x0020B253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0020D05C File Offset: 0x0020B25C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005C39 RID: 23609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C3A RID: 23610
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005C3B RID: 23611
		private ErrorCode errorCode_;
	}
}
