using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6B RID: 3179
	[NetMessage(EMessageId.PhantomBattleDeployNotify)]
	public sealed class PhantomBattleDeployNotify : IMessage<PhantomBattleDeployNotify>, IMessage, IEquatable<PhantomBattleDeployNotify>, IDeepCloneable<PhantomBattleDeployNotify>, IBufferMessage
	{
		// Token: 0x06011416 RID: 70678 RVA: 0x00287468 File Offset: 0x00285668
		[NullableContext(1)]
		public static PhantomBattleDeployNotify Create()
		{
			return new PhantomBattleDeployNotify();
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x06011417 RID: 70679 RVA: 0x0028746F File Offset: 0x0028566F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06011418 RID: 70680 RVA: 0x00287472 File Offset: 0x00285672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDeployNotify.Descriptor;
			}
		}

		// Token: 0x06011419 RID: 70681 RVA: 0x00287479 File Offset: 0x00285679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify()
		{
		}

		// Token: 0x0601141A RID: 70682 RVA: 0x00287481 File Offset: 0x00285681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify(PhantomBattleDeployNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601141B RID: 70683 RVA: 0x0028749A File Offset: 0x0028569A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify Clone()
		{
			return new PhantomBattleDeployNotify(this);
		}

		// Token: 0x0601141C RID: 70684 RVA: 0x002874A2 File Offset: 0x002856A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDeployNotify);
		}

		// Token: 0x0601141D RID: 70685 RVA: 0x002874B0 File Offset: 0x002856B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDeployNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601141E RID: 70686 RVA: 0x002874D0 File Offset: 0x002856D0
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

		// Token: 0x0601141F RID: 70687 RVA: 0x002874F6 File Offset: 0x002856F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011420 RID: 70688 RVA: 0x00287503 File Offset: 0x00285703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011421 RID: 70689 RVA: 0x0028750C File Offset: 0x0028570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011422 RID: 70690 RVA: 0x00287524 File Offset: 0x00285724
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

		// Token: 0x06011423 RID: 70691 RVA: 0x0028754A File Offset: 0x0028574A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDeployNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011424 RID: 70692 RVA: 0x00287567 File Offset: 0x00285767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011425 RID: 70693 RVA: 0x00287570 File Offset: 0x00285770
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

		// Token: 0x04006D91 RID: 28049
		private UnknownFieldSet _unknownFields;
	}
}
