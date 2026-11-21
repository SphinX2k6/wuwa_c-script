using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FA RID: 4858
	[NetMessage(EMessageId.StartMatchNotify)]
	public sealed class StartMatchNotify : IMessage<StartMatchNotify>, IMessage, IEquatable<StartMatchNotify>, IDeepCloneable<StartMatchNotify>, IBufferMessage
	{
		// Token: 0x06019EA8 RID: 106152 RVA: 0x003C790F File Offset: 0x003C5B0F
		[NullableContext(1)]
		public static StartMatchNotify Create()
		{
			return new StartMatchNotify();
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x06019EA9 RID: 106153 RVA: 0x003C7916 File Offset: 0x003C5B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x06019EAA RID: 106154 RVA: 0x003C7919 File Offset: 0x003C5B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchNotify.Descriptor;
			}
		}

		// Token: 0x06019EAB RID: 106155 RVA: 0x003C7920 File Offset: 0x003C5B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify()
		{
		}

		// Token: 0x06019EAC RID: 106156 RVA: 0x003C7928 File Offset: 0x003C5B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify(StartMatchNotify other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x003C794D File Offset: 0x003C5B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify Clone()
		{
			return new StartMatchNotify(this);
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x06019EAE RID: 106158 RVA: 0x003C7955 File Offset: 0x003C5B55
		// (set) Token: 0x06019EAF RID: 106159 RVA: 0x003C795D File Offset: 0x003C5B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06019EB0 RID: 106160 RVA: 0x003C7966 File Offset: 0x003C5B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchNotify);
		}

		// Token: 0x06019EB1 RID: 106161 RVA: 0x003C7974 File Offset: 0x003C5B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EB2 RID: 106162 RVA: 0x003C79A4 File Offset: 0x003C5BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019EB3 RID: 106163 RVA: 0x003C79E3 File Offset: 0x003C5BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EB4 RID: 106164 RVA: 0x003C79F0 File Offset: 0x003C5BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x003C79F9 File Offset: 0x003C5BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x003C7A2C File Offset: 0x003C5C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019EB7 RID: 106167 RVA: 0x003C7A6A File Offset: 0x003C5C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EB8 RID: 106168 RVA: 0x003C7A9B File Offset: 0x003C5C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EB9 RID: 106169 RVA: 0x003C7AA4 File Offset: 0x003C5CA4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098D0 RID: 39120
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098D1 RID: 39121
		public const int InstIdFieldNumber = 5;

		// Token: 0x040098D2 RID: 39122
		private int instId_;
	}
}
