using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001018 RID: 4120
	public sealed class RogueViewPackage : IMessage<RogueViewPackage>, IMessage, IEquatable<RogueViewPackage>, IDeepCloneable<RogueViewPackage>, IBufferMessage
	{
		// Token: 0x060160CC RID: 90316 RVA: 0x00334D49 File Offset: 0x00332F49
		[NullableContext(1)]
		public static RogueViewPackage Create()
		{
			return new RogueViewPackage();
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x060160CD RID: 90317 RVA: 0x00334D50 File Offset: 0x00332F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x060160CE RID: 90318 RVA: 0x00334D53 File Offset: 0x00332F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewPackage.Descriptor;
			}
		}

		// Token: 0x060160CF RID: 90319 RVA: 0x00334D5A File Offset: 0x00332F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage()
		{
		}

		// Token: 0x060160D0 RID: 90320 RVA: 0x00334D6D File Offset: 0x00332F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage(RogueViewPackage other) : this()
		{
			this.rogueViewGroups_ = other.rogueViewGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160D1 RID: 90321 RVA: 0x00334D97 File Offset: 0x00332F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage Clone()
		{
			return new RogueViewPackage(this);
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x060160D2 RID: 90322 RVA: 0x00334D9F File Offset: 0x00332F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueViewGroup> RogueViewGroups
		{
			get
			{
				return this.rogueViewGroups_;
			}
		}

		// Token: 0x060160D3 RID: 90323 RVA: 0x00334DA7 File Offset: 0x00332FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewPackage);
		}

		// Token: 0x060160D4 RID: 90324 RVA: 0x00334DB5 File Offset: 0x00332FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewPackage other)
		{
			return other != null && (other == this || (this.rogueViewGroups_.Equals(other.rogueViewGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160D5 RID: 90325 RVA: 0x00334DE8 File Offset: 0x00332FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueViewGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060160D6 RID: 90326 RVA: 0x00334E1C File Offset: 0x0033301C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160D7 RID: 90327 RVA: 0x00334E29 File Offset: 0x00333029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160D8 RID: 90328 RVA: 0x00334E32 File Offset: 0x00333032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueViewGroups_.WriteTo(ref output, RogueViewPackage._repeated_rogueViewGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160D9 RID: 90329 RVA: 0x00334E5C File Offset: 0x0033305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueViewGroups_.CalculateSize(RogueViewPackage._repeated_rogueViewGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060160DA RID: 90330 RVA: 0x00334E95 File Offset: 0x00333095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueViewPackage other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueViewGroups_.Add(other.rogueViewGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060160DB RID: 90331 RVA: 0x00334EC3 File Offset: 0x003330C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160DC RID: 90332 RVA: 0x00334ECC File Offset: 0x003330CC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueViewGroups_.AddEntriesFrom(ref input, RogueViewPackage._repeated_rogueViewGroups_codec);
				}
			}
		}

		// Token: 0x04008493 RID: 33939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008494 RID: 33940
		public const int RogueViewGroupsFieldNumber = 1;

		// Token: 0x04008495 RID: 33941
		private static readonly FieldCodec<RogueViewGroup> _repeated_rogueViewGroups_codec = FieldCodec.ForMessage<RogueViewGroup>(10U, RogueViewGroup.Parser);

		// Token: 0x04008496 RID: 33942
		private readonly RepeatedField<RogueViewGroup> rogueViewGroups_ = new RepeatedField<RogueViewGroup>();
	}
}
