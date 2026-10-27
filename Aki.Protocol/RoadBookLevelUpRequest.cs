using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6E RID: 3950
	[NetMessage(EMessageId.RoadBookLevelUpRequest)]
	public sealed class RoadBookLevelUpRequest : IMessage<RoadBookLevelUpRequest>, IMessage, IEquatable<RoadBookLevelUpRequest>, IDeepCloneable<RoadBookLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060151ED RID: 86509 RVA: 0x0030FFC5 File Offset: 0x0030E1C5
		[NullableContext(1)]
		public static RoadBookLevelUpRequest Create()
		{
			return new RoadBookLevelUpRequest();
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x060151EE RID: 86510 RVA: 0x0030FFCC File Offset: 0x0030E1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x060151EF RID: 86511 RVA: 0x0030FFCF File Offset: 0x0030E1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060151F0 RID: 86512 RVA: 0x0030FFD6 File Offset: 0x0030E1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest()
		{
		}

		// Token: 0x060151F1 RID: 86513 RVA: 0x0030FFDE File Offset: 0x0030E1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest(RoadBookLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151F2 RID: 86514 RVA: 0x0030FFF7 File Offset: 0x0030E1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest Clone()
		{
			return new RoadBookLevelUpRequest(this);
		}

		// Token: 0x060151F3 RID: 86515 RVA: 0x0030FFFF File Offset: 0x0030E1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookLevelUpRequest);
		}

		// Token: 0x060151F4 RID: 86516 RVA: 0x0031000D File Offset: 0x0030E20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060151F5 RID: 86517 RVA: 0x0031002C File Offset: 0x0030E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060151F6 RID: 86518 RVA: 0x00310052 File Offset: 0x0030E252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151F7 RID: 86519 RVA: 0x0031005F File Offset: 0x0030E25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151F8 RID: 86520 RVA: 0x00310068 File Offset: 0x0030E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151F9 RID: 86521 RVA: 0x00310080 File Offset: 0x0030E280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151FA RID: 86522 RVA: 0x003100A6 File Offset: 0x0030E2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151FB RID: 86523 RVA: 0x003100C3 File Offset: 0x0030E2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151FC RID: 86524 RVA: 0x003100CC File Offset: 0x0030E2CC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F17 RID: 32535
		private UnknownFieldSet _unknownFields;
	}
}
