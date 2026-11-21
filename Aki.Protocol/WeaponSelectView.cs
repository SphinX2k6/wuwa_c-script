using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156E RID: 5486
	public sealed class WeaponSelectView : IMessage<WeaponSelectView>, IMessage, IEquatable<WeaponSelectView>, IDeepCloneable<WeaponSelectView>, IBufferMessage
	{
		// Token: 0x0601D0DB RID: 119003 RVA: 0x004355C3 File Offset: 0x004337C3
		[NullableContext(1)]
		public static WeaponSelectView Create()
		{
			return new WeaponSelectView();
		}

		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x0601D0DC RID: 119004 RVA: 0x004355CA File Offset: 0x004337CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x0601D0DD RID: 119005 RVA: 0x004355CD File Offset: 0x004337CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSelectView.Descriptor;
			}
		}

		// Token: 0x0601D0DE RID: 119006 RVA: 0x004355D4 File Offset: 0x004337D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView()
		{
		}

		// Token: 0x0601D0DF RID: 119007 RVA: 0x004355DC File Offset: 0x004337DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView(WeaponSelectView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0E0 RID: 119008 RVA: 0x00435611 File Offset: 0x00433811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView Clone()
		{
			return new WeaponSelectView(this);
		}

		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x0601D0E1 RID: 119009 RVA: 0x00435619 File Offset: 0x00433819
		// (set) Token: 0x0601D0E2 RID: 119010 RVA: 0x00435621 File Offset: 0x00433821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption SurvivorsOption
		{
			get
			{
				return this.survivorsOption_;
			}
			set
			{
				this.survivorsOption_ = value;
			}
		}

		// Token: 0x0601D0E3 RID: 119011 RVA: 0x0043562A File Offset: 0x0043382A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSelectView);
		}

		// Token: 0x0601D0E4 RID: 119012 RVA: 0x00435638 File Offset: 0x00433838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSelectView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x0043566C File Offset: 0x0043386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorsOption_ != null)
			{
				num ^= this.SurvivorsOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0E6 RID: 119014 RVA: 0x004356A8 File Offset: 0x004338A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0E7 RID: 119015 RVA: 0x004356B5 File Offset: 0x004338B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x004356BE File Offset: 0x004338BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorsOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0E9 RID: 119017 RVA: 0x004356F0 File Offset: 0x004338F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorsOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0EA RID: 119018 RVA: 0x00435730 File Offset: 0x00433930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSelectView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorsOption_ != null)
			{
				if (this.survivorsOption_ == null)
				{
					this.SurvivorsOption = new SurvivorsOption();
				}
				this.SurvivorsOption.MergeFrom(other.SurvivorsOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0EB RID: 119019 RVA: 0x00435784 File Offset: 0x00433984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0EC RID: 119020 RVA: 0x00435790 File Offset: 0x00433990
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
					if (this.survivorsOption_ == null)
					{
						this.SurvivorsOption = new SurvivorsOption();
					}
					input.ReadMessage(this.SurvivorsOption);
				}
			}
		}

		// Token: 0x0400A6EB RID: 42731
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6EC RID: 42732
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x0400A6ED RID: 42733
		private SurvivorsOption survivorsOption_;
	}
}
