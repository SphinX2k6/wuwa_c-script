using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A46 RID: 2630
	[NetMessage(EMessageId.MotorFightLastSaveDataRequest)]
	public sealed class MotorFightLastSaveDataRequest : IMessage<MotorFightLastSaveDataRequest>, IMessage, IEquatable<MotorFightLastSaveDataRequest>, IDeepCloneable<MotorFightLastSaveDataRequest>, IBufferMessage
	{
		// Token: 0x0600E591 RID: 58769 RVA: 0x00218E12 File Offset: 0x00217012
		[NullableContext(1)]
		public static MotorFightLastSaveDataRequest Create()
		{
			return new MotorFightLastSaveDataRequest();
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600E592 RID: 58770 RVA: 0x00218E19 File Offset: 0x00217019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600E593 RID: 58771 RVA: 0x00218E1C File Offset: 0x0021701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveDataRequest.Descriptor;
			}
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x00218E23 File Offset: 0x00217023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest()
		{
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x00218E2B File Offset: 0x0021702B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest(MotorFightLastSaveDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x00218E44 File Offset: 0x00217044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest Clone()
		{
			return new MotorFightLastSaveDataRequest(this);
		}

		// Token: 0x0600E597 RID: 58775 RVA: 0x00218E4C File Offset: 0x0021704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveDataRequest);
		}

		// Token: 0x0600E598 RID: 58776 RVA: 0x00218E5A File Offset: 0x0021705A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E599 RID: 58777 RVA: 0x00218E78 File Offset: 0x00217078
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

		// Token: 0x0600E59A RID: 58778 RVA: 0x00218E9E File Offset: 0x0021709E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E59B RID: 58779 RVA: 0x00218EAB File Offset: 0x002170AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x00218EB4 File Offset: 0x002170B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x00218ECC File Offset: 0x002170CC
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

		// Token: 0x0600E59E RID: 58782 RVA: 0x00218EF2 File Offset: 0x002170F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLastSaveDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x00218F0F File Offset: 0x0021710F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x00218F18 File Offset: 0x00217118
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

		// Token: 0x04005DC7 RID: 24007
		private UnknownFieldSet _unknownFields;
	}
}
