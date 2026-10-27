using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BB RID: 2491
	[NetMessage(EMessageId.MatchingNotify)]
	public sealed class MatchingNotify : IMessage<MatchingNotify>, IMessage, IEquatable<MatchingNotify>, IDeepCloneable<MatchingNotify>, IBufferMessage
	{
		// Token: 0x0600DA81 RID: 55937 RVA: 0x00201269 File Offset: 0x001FF469
		[NullableContext(1)]
		public static MatchingNotify Create()
		{
			return new MatchingNotify();
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x00201270 File Offset: 0x001FF470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x00201273 File Offset: 0x001FF473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchingNotify.Descriptor;
			}
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x0020127A File Offset: 0x001FF47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify()
		{
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x00201282 File Offset: 0x001FF482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify(MatchingNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x0020129B File Offset: 0x001FF49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify Clone()
		{
			return new MatchingNotify(this);
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x002012A3 File Offset: 0x001FF4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchingNotify);
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x002012B1 File Offset: 0x001FF4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchingNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x002012D0 File Offset: 0x001FF4D0
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

		// Token: 0x0600DA8A RID: 55946 RVA: 0x002012F6 File Offset: 0x001FF4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA8B RID: 55947 RVA: 0x00201303 File Offset: 0x001FF503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA8C RID: 55948 RVA: 0x0020130C File Offset: 0x001FF50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x00201324 File Offset: 0x001FF524
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

		// Token: 0x0600DA8E RID: 55950 RVA: 0x0020134A File Offset: 0x001FF54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00201367 File Offset: 0x001FF567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA90 RID: 55952 RVA: 0x00201370 File Offset: 0x001FF570
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

		// Token: 0x04005AB5 RID: 23221
		private UnknownFieldSet _unknownFields;
	}
}
