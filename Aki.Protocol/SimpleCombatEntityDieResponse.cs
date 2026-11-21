using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001262 RID: 4706
	[NetMessage(EMessageId.SimpleCombatEntityDieResponse)]
	public sealed class SimpleCombatEntityDieResponse : IMessage<SimpleCombatEntityDieResponse>, IMessage, IEquatable<SimpleCombatEntityDieResponse>, IDeepCloneable<SimpleCombatEntityDieResponse>, IBufferMessage
	{
		// Token: 0x0601920B RID: 102923 RVA: 0x003AA754 File Offset: 0x003A8954
		[NullableContext(1)]
		public static SimpleCombatEntityDieResponse Create()
		{
			return new SimpleCombatEntityDieResponse();
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x0601920C RID: 102924 RVA: 0x003AA75B File Offset: 0x003A895B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x0601920D RID: 102925 RVA: 0x003AA75E File Offset: 0x003A895E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieResponse.Descriptor;
			}
		}

		// Token: 0x0601920E RID: 102926 RVA: 0x003AA765 File Offset: 0x003A8965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse()
		{
		}

		// Token: 0x0601920F RID: 102927 RVA: 0x003AA76D File Offset: 0x003A896D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse(SimpleCombatEntityDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019210 RID: 102928 RVA: 0x003AA792 File Offset: 0x003A8992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse Clone()
		{
			return new SimpleCombatEntityDieResponse(this);
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x06019211 RID: 102929 RVA: 0x003AA79A File Offset: 0x003A899A
		// (set) Token: 0x06019212 RID: 102930 RVA: 0x003AA7A2 File Offset: 0x003A89A2
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

		// Token: 0x06019213 RID: 102931 RVA: 0x003AA7AB File Offset: 0x003A89AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieResponse);
		}

		// Token: 0x06019214 RID: 102932 RVA: 0x003AA7B9 File Offset: 0x003A89B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019215 RID: 102933 RVA: 0x003AA7E8 File Offset: 0x003A89E8
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

		// Token: 0x06019216 RID: 102934 RVA: 0x003AA82D File Offset: 0x003A8A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019217 RID: 102935 RVA: 0x003AA83A File Offset: 0x003A8A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019218 RID: 102936 RVA: 0x003AA843 File Offset: 0x003A8A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019219 RID: 102937 RVA: 0x003AA878 File Offset: 0x003A8A78
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

		// Token: 0x0601921A RID: 102938 RVA: 0x003AA8B6 File Offset: 0x003A8AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityDieResponse other)
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

		// Token: 0x0601921B RID: 102939 RVA: 0x003AA8E7 File Offset: 0x003A8AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601921C RID: 102940 RVA: 0x003AA8F0 File Offset: 0x003A8AF0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094D6 RID: 38102
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094D7 RID: 38103
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040094D8 RID: 38104
		private ErrorCode errorCode_;
	}
}
