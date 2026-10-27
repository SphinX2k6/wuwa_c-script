using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3C RID: 3132
	[NetMessage(EMessageId.PhantomBattleBvBLoadingFinishRequest)]
	public sealed class PhantomBattleBvBLoadingFinishRequest : IMessage<PhantomBattleBvBLoadingFinishRequest>, IMessage, IEquatable<PhantomBattleBvBLoadingFinishRequest>, IDeepCloneable<PhantomBattleBvBLoadingFinishRequest>, IBufferMessage
	{
		// Token: 0x06010FBC RID: 69564 RVA: 0x0027C636 File Offset: 0x0027A836
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingFinishRequest Create()
		{
			return new PhantomBattleBvBLoadingFinishRequest();
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x06010FBD RID: 69565 RVA: 0x0027C63D File Offset: 0x0027A83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x06010FBE RID: 69566 RVA: 0x0027C640 File Offset: 0x0027A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingFinishRequest.Descriptor;
			}
		}

		// Token: 0x06010FBF RID: 69567 RVA: 0x0027C647 File Offset: 0x0027A847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest()
		{
		}

		// Token: 0x06010FC0 RID: 69568 RVA: 0x0027C64F File Offset: 0x0027A84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest(PhantomBattleBvBLoadingFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FC1 RID: 69569 RVA: 0x0027C668 File Offset: 0x0027A868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishRequest Clone()
		{
			return new PhantomBattleBvBLoadingFinishRequest(this);
		}

		// Token: 0x06010FC2 RID: 69570 RVA: 0x0027C670 File Offset: 0x0027A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingFinishRequest);
		}

		// Token: 0x06010FC3 RID: 69571 RVA: 0x0027C67E File Offset: 0x0027A87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010FC4 RID: 69572 RVA: 0x0027C69C File Offset: 0x0027A89C
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

		// Token: 0x06010FC5 RID: 69573 RVA: 0x0027C6C2 File Offset: 0x0027A8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FC6 RID: 69574 RVA: 0x0027C6CF File Offset: 0x0027A8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FC7 RID: 69575 RVA: 0x0027C6D8 File Offset: 0x0027A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FC8 RID: 69576 RVA: 0x0027C6F0 File Offset: 0x0027A8F0
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

		// Token: 0x06010FC9 RID: 69577 RVA: 0x0027C716 File Offset: 0x0027A916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FCA RID: 69578 RVA: 0x0027C733 File Offset: 0x0027A933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FCB RID: 69579 RVA: 0x0027C73C File Offset: 0x0027A93C
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

		// Token: 0x04006BA0 RID: 27552
		private UnknownFieldSet _unknownFields;
	}
}
