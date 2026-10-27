using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001180 RID: 4480
	[NetMessage(EMessageId.SceneModeChangeFinishRequest)]
	public sealed class SceneModeChangeFinishRequest : IMessage<SceneModeChangeFinishRequest>, IMessage, IEquatable<SceneModeChangeFinishRequest>, IDeepCloneable<SceneModeChangeFinishRequest>, IBufferMessage
	{
		// Token: 0x06017DFF RID: 97791 RVA: 0x003776FE File Offset: 0x003758FE
		[NullableContext(1)]
		public static SceneModeChangeFinishRequest Create()
		{
			return new SceneModeChangeFinishRequest();
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x06017E00 RID: 97792 RVA: 0x00377705 File Offset: 0x00375905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x06017E01 RID: 97793 RVA: 0x00377708 File Offset: 0x00375908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneModeChangeFinishRequest.Descriptor;
			}
		}

		// Token: 0x06017E02 RID: 97794 RVA: 0x0037770F File Offset: 0x0037590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest()
		{
		}

		// Token: 0x06017E03 RID: 97795 RVA: 0x00377717 File Offset: 0x00375917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest(SceneModeChangeFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x00377730 File Offset: 0x00375930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest Clone()
		{
			return new SceneModeChangeFinishRequest(this);
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x00377738 File Offset: 0x00375938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneModeChangeFinishRequest);
		}

		// Token: 0x06017E06 RID: 97798 RVA: 0x00377746 File Offset: 0x00375946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneModeChangeFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06017E07 RID: 97799 RVA: 0x00377764 File Offset: 0x00375964
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

		// Token: 0x06017E08 RID: 97800 RVA: 0x0037778A File Offset: 0x0037598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E09 RID: 97801 RVA: 0x00377797 File Offset: 0x00375997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E0A RID: 97802 RVA: 0x003777A0 File Offset: 0x003759A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E0B RID: 97803 RVA: 0x003777B8 File Offset: 0x003759B8
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

		// Token: 0x06017E0C RID: 97804 RVA: 0x003777DE File Offset: 0x003759DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneModeChangeFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E0D RID: 97805 RVA: 0x003777FB File Offset: 0x003759FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E0E RID: 97806 RVA: 0x00377804 File Offset: 0x00375A04
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

		// Token: 0x04008D71 RID: 36209
		private UnknownFieldSet _unknownFields;
	}
}
