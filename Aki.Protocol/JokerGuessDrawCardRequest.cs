using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000859 RID: 2137
	[NetMessage(EMessageId.JokerGuessDrawCardRequest)]
	public sealed class JokerGuessDrawCardRequest : IMessage<JokerGuessDrawCardRequest>, IMessage, IEquatable<JokerGuessDrawCardRequest>, IDeepCloneable<JokerGuessDrawCardRequest>, IBufferMessage
	{
		// Token: 0x0600BEC1 RID: 48833 RVA: 0x001C56E2 File Offset: 0x001C38E2
		[NullableContext(1)]
		public static JokerGuessDrawCardRequest Create()
		{
			return new JokerGuessDrawCardRequest();
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x001C56E9 File Offset: 0x001C38E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x001C56EC File Offset: 0x001C38EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardRequest.Descriptor;
			}
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x001C56F3 File Offset: 0x001C38F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest()
		{
		}

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x001C56FB File Offset: 0x001C38FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest(JokerGuessDrawCardRequest other) : this()
		{
			this.targetCardId_ = other.targetCardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x001C5720 File Offset: 0x001C3920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest Clone()
		{
			return new JokerGuessDrawCardRequest(this);
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600BEC7 RID: 48839 RVA: 0x001C5728 File Offset: 0x001C3928
		// (set) Token: 0x0600BEC8 RID: 48840 RVA: 0x001C5730 File Offset: 0x001C3930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetCardId
		{
			get
			{
				return this.targetCardId_;
			}
			set
			{
				this.targetCardId_ = value;
			}
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x001C5739 File Offset: 0x001C3939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardRequest);
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x001C5747 File Offset: 0x001C3947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardRequest other)
		{
			return other != null && (other == this || (this.TargetCardId == other.TargetCardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BECB RID: 48843 RVA: 0x001C5778 File Offset: 0x001C3978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetCardId != 0)
			{
				num ^= this.TargetCardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BECC RID: 48844 RVA: 0x001C57B7 File Offset: 0x001C39B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BECD RID: 48845 RVA: 0x001C57C4 File Offset: 0x001C39C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BECE RID: 48846 RVA: 0x001C57CD File Offset: 0x001C39CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetCardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TargetCardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BECF RID: 48847 RVA: 0x001C5800 File Offset: 0x001C3A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetCardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x001C583E File Offset: 0x001C3A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDrawCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetCardId != 0)
			{
				this.TargetCardId = other.TargetCardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BED1 RID: 48849 RVA: 0x001C586F File Offset: 0x001C3A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x001C5878 File Offset: 0x001C3A78
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
					this.TargetCardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005379 RID: 21369
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400537A RID: 21370
		public const int TargetCardIdFieldNumber = 8;

		// Token: 0x0400537B RID: 21371
		private int targetCardId_;
	}
}
