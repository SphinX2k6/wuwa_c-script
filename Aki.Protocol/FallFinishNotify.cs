using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000505 RID: 1285
	[NetMessage(EMessageId.FallFinishNotify)]
	public sealed class FallFinishNotify : IMessage<FallFinishNotify>, IMessage, IEquatable<FallFinishNotify>, IDeepCloneable<FallFinishNotify>, IBufferMessage
	{
		// Token: 0x06007951 RID: 31057 RVA: 0x0012741F File Offset: 0x0012561F
		[NullableContext(1)]
		public static FallFinishNotify Create()
		{
			return new FallFinishNotify();
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x00127426 File Offset: 0x00125626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06007953 RID: 31059 RVA: 0x00127429 File Offset: 0x00125629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallFinishNotify.Descriptor;
			}
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00127430 File Offset: 0x00125630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify()
		{
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x00127438 File Offset: 0x00125638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify(FallFinishNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x00127451 File Offset: 0x00125651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallFinishNotify Clone()
		{
			return new FallFinishNotify(this);
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00127459 File Offset: 0x00125659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallFinishNotify);
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00127467 File Offset: 0x00125667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FallFinishNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00127488 File Offset: 0x00125688
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

		// Token: 0x0600795A RID: 31066 RVA: 0x001274AE File Offset: 0x001256AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x001274BB File Offset: 0x001256BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x001274C4 File Offset: 0x001256C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x001274DC File Offset: 0x001256DC
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

		// Token: 0x0600795E RID: 31070 RVA: 0x00127502 File Offset: 0x00125702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FallFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x0012751F File Offset: 0x0012571F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00127528 File Offset: 0x00125728
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

		// Token: 0x04003EF4 RID: 16116
		private UnknownFieldSet _unknownFields;
	}
}
