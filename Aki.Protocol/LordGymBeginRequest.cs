using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095B RID: 2395
	[NetMessage(EMessageId.LordGymBeginRequest)]
	public sealed class LordGymBeginRequest : IMessage<LordGymBeginRequest>, IMessage, IEquatable<LordGymBeginRequest>, IDeepCloneable<LordGymBeginRequest>, IBufferMessage
	{
		// Token: 0x0600D30F RID: 54031 RVA: 0x001F1A90 File Offset: 0x001EFC90
		[NullableContext(1)]
		public static LordGymBeginRequest Create()
		{
			return new LordGymBeginRequest();
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x001F1A97 File Offset: 0x001EFC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600D311 RID: 54033 RVA: 0x001F1A9A File Offset: 0x001EFC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymBeginRequest.Descriptor;
			}
		}

		// Token: 0x0600D312 RID: 54034 RVA: 0x001F1AA1 File Offset: 0x001EFCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest()
		{
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x001F1AA9 File Offset: 0x001EFCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest(LordGymBeginRequest other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D314 RID: 54036 RVA: 0x001F1ACE File Offset: 0x001EFCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest Clone()
		{
			return new LordGymBeginRequest(this);
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600D315 RID: 54037 RVA: 0x001F1AD6 File Offset: 0x001EFCD6
		// (set) Token: 0x0600D316 RID: 54038 RVA: 0x001F1ADE File Offset: 0x001EFCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x001F1AE7 File Offset: 0x001EFCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymBeginRequest);
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x001F1AF5 File Offset: 0x001EFCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymBeginRequest other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x001F1B24 File Offset: 0x001EFD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x001F1B63 File Offset: 0x001EFD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x001F1B70 File Offset: 0x001EFD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x001F1B79 File Offset: 0x001EFD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D31D RID: 54045 RVA: 0x001F1BAC File Offset: 0x001EFDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D31E RID: 54046 RVA: 0x001F1BEA File Offset: 0x001EFDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymBeginRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D31F RID: 54047 RVA: 0x001F1C1B File Offset: 0x001EFE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D320 RID: 54048 RVA: 0x001F1C24 File Offset: 0x001EFE24
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
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058BF RID: 22719
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C0 RID: 22720
		public const int LoadGymIdFieldNumber = 9;

		// Token: 0x040058C1 RID: 22721
		private int loadGymId_;
	}
}
